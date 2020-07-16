
using Cronometro.Model.bean;
using MySql.Data.MySqlClient;
using Sealevel;
using SONY.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro.View
{
    public partial class Cronometrod : Form
    {
        private Stopwatch cronometro = new Stopwatch();
        private SeaIOClassic sio = new SeaIOClassic();
        private SeaIOClassic.Error response = 0;
        private int vezParcial = 0, length = 1, canal;
        private String  posto, modelo, operador;
        private byte[] pBuffer = { 0 };
        private ushort card;
        private List<TimerLista> listaTimer;
        private DateTime dates = DateTime.Now;
        private IniFile ini;
        private TimerDB timerDB = new TimerDB();
        private bool check = false;
        private MySqlConnection mConn;
        public Cronometrod()
        {
            InitializeComponent();
            lblfeedback.Text = "Bem vindo!";
            ini = new IniFile(".\\Config.ini", 1024);
            recuperarInformacoes();
            AbrirConexaoSQL();
        }

        private void AbrirConexaoSQL()
        {
            //string de conexão com o banco de dados
            mConn = new MySqlConnection("Persist Security Info=False; server=*********;database=timer;uid=********;password=**********;charset=utf8;pooling=false");
          
            try
            {
                //abre a conexao
                mConn.Open();
            }
            catch (System.Exception e)
            {
                //mostrar erro na tela
                lblfeedback.BackColor = System.Drawing.Color.Red;
                lblfeedback.Text = "Erro! Sem conexão com banco de dados";
                tmrReadAllInputs.Enabled = false;
            }
        }
        private void recuperarInformacoes()
        {
            //recuperar informações do arquivo ini
            canal = int.Parse(ini.readString("Config", "Canal", ""));
            card = ushort.Parse(ini.readString("Config", "Card", ""));
			posto = ini.readString("Config", "Posto", "");
            operador = ini.readString("Config", "Operador", "");
            modelo = ini.readString("Config", "Modelo", "");

            // preencher labels com ultimas configurações
            lbCanal.Text = "Canal:" + canal;
            lbCard.Text = "Card:" + card;
			lbPosto.Text = "Posto:" + posto;
            lbOperador.Text = "Operador:" + operador;
            lbModelo.Text = "Modelo:" + modelo;
        }
        private void abrirConexao()
        {
            response = sio.OpenDevice(card);
            if (response != SeaIOClassic.Error.None)
            {
                //mostrar erro na tela
                lblfeedback.BackColor = System.Drawing.Color.Red;
                lblfeedback.Text = "Erro! Verificar Dispositivo ou arquivo de configuração";
            }
        }
        private async Task delayReadInputs()
        {
            tmrReadAllInputs.Enabled = false;
            await Task.Delay(15000);
            tmrReadAllInputs.Enabled = true;
        }
        private void  readInputs()
        {
           abrirConexao();
           response = sio.ReadAllInputs(pBuffer, length);
            sio.CloseDevice();
        }
        private async Task iniciarCronometro()
        {
            if ((response == SeaIOClassic.Error.None) && check == false)
            {
                if ((pBuffer[0] & (1 << (canal - 1))) != 0)
                {
                    cronometro.Reset();
                    cronometro.Start();
                    lblfeedback.BackColor = System.Drawing.Color.LightGreen;
                    lblfeedback.Text = "Cronômetro Iniciado";
                    await delayReadInputs();
                    check = true;
                }
            }
        }
        private void pararCronometro()
        {
            if ((response == SeaIOClassic.Error.None) && check == true)
            {
                if ((pBuffer[0] & (1 << (canal - 1))) != 0)
                {
                    cronometro.Stop();
                    lblfeedback.BackColor = System.Drawing.Color.Red;
                    lblfeedback.Text = "Cronometro Parado";
                    vezParcial++;
                    try
                    {
                        Timer1 timer = new Timer1(double.Parse(lblTempo.Text), dates.ToString("yyyy-MM-dd"), dates.ToString("HH:mm:ss"), posto, modelo, operador);
                        timerDB.salvar(timer);
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show(c.ToString());
                    }
                    listaTimer = new List<TimerLista>{new TimerLista {idTimer = vezParcial, Tempo = lblTempo.Text}
                     };

                    foreach (var item in listaTimer)
                    {
                        StateOperlv.Items.Add(new ListViewItem(new string[] { item.idTimer.ToString(), item.Tempo }));
                    }
                    System.Threading.Thread.Sleep(350);
                    check = false;
                }
            }
        }
        private void tmrReadAllInputs_Tick(object sender, EventArgs e)
        {
            readInputs();
            if (check == false)
            {
                iniciarCronometro();
            }
            else
            {
                pararCronometro();
            }
        }
        private void tmrLabelCronometro_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = $"{(int)cronometro.Elapsed.TotalSeconds}";
        }
        private void btConfigurar_Click(object sender, EventArgs e)
        { 
            Setup setup = new Setup();
            setup.Show();
            this.Close();
        }
    }
}
