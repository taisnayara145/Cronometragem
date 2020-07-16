using SONY.Modules;
using System;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Setup : Form
    {
        private TimerDB timerDB = new TimerDB();
        private IniFile ini;
        public Setup()
        {
            InitializeComponent();
			preencherCBPosto();
            preencherCBModelo();
            ini = new IniFile(".\\Config.ini", 1024);
            recuperarInformacoes();
        }
        private void recuperarInformacoes()
        {
            tbCanal.Text = ini.readString("Config", "Canal", "");
            tbPorta.Text = ini.readString("Config", "Card", "");
            tbOperador.Text = ini.readString("Config", "Operador", "");
			cbPosto.Text = ini.readString("Config", "Posto", "");
            cbModelo.Text = ini.readString("Config", "Modelo", "");
        }
		private void preencherCBPosto()
        {
            cbPosto.DisplayMember = "postonome";
            cbPosto.ValueMember = "postocod";
            cbPosto.DataSource = timerDB.preencherCBPosto();
        }
        private void preencherCBModelo()
        {
            cbModelo.DisplayMember = "modelonome";
            cbModelo.ValueMember = "modelocod";
            cbModelo.DataSource = timerDB.preencherCBModelo();
        }
        private void btSalvar_Click(object sender, System.EventArgs e)
        {
            //pegar informações de TextBox e ComboBox
            int canal = int.Parse(tbCanal.Text);
            int card = int.Parse(tbPorta.Text);
			String posto = comboPosto.Text.ToString();
            String operador = tbOperador.Text;
            String modelo = comboModelo.Text.ToString();

            if (tbCanal.Text.Equals("") && tbPorta.Text.Equals("")) {
               //Se campos obrigatórios não preenchidos
                MessageBox.Show("Preencha todos os campos!");
            }
           else
            {
                //Se campos obrigatórios preenchidos, salvar e abrir tela com o cronometro
                 ini.writeString("Config", "Canal", canal.ToString());
                 ini.writeString("Config", "Card", card.ToString());
				 ini.writeString("Config", "Posto", posto);
                 ini.writeString("Config", "Operador", operador);
                 ini.writeString("Config", "Modelo", modelo);

                MessageBox.Show("Configurações salvas!!!");

                View.Cronometrod f= new View.Cronometrod();

                f.Show();
                f.Refresh();
                this.Close();
            }
        }
    }
}
