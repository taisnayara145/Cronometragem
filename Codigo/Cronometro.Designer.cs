namespace Cronometro.View
{
    partial class Cronometrod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometrod));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTempo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StateOperlv = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbOperador = new System.Windows.Forms.Label();
            this.lbCanal = new System.Windows.Forms.Label();
            this.lbCard = new System.Windows.Forms.Label();
            this.lbPosto = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbLinha = new System.Windows.Forms.Label();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.btConfigurar = new System.Windows.Forms.Button();
            this.tmrLabelCronometro = new System.Windows.Forms.Timer(this.components);
            this.tmrReadAllInputs = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(249, 106);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTempo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(241, 80);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cronômetro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(69, 0);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(107, 76);
            this.lblTempo.TabIndex = 1;
            this.lblTempo.Text = "00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StateOperlv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(241, 80);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Leituras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StateOperlv
            // 
            this.StateOperlv.AllowColumnReorder = true;
            this.StateOperlv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StateOperlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.StateOperlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateOperlv.FullRowSelect = true;
            this.StateOperlv.GridLines = true;
            this.StateOperlv.HideSelection = false;
            this.StateOperlv.Location = new System.Drawing.Point(3, 6);
            this.StateOperlv.Name = "StateOperlv";
            this.StateOperlv.Size = new System.Drawing.Size(232, 68);
            this.StateOperlv.TabIndex = 5;
            this.StateOperlv.UseCompatibleStateImageBehavior = false;
            this.StateOperlv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Leitura";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tempo de execução";
            this.columnHeader3.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbOperador);
            this.tabPage3.Controls.Add(this.lbCanal);
            this.tabPage3.Controls.Add(this.lbCard);
            this.tabPage3.Controls.Add(this.lbPosto);
            this.tabPage3.Controls.Add(this.lbModelo);
            this.tabPage3.Controls.Add(this.lbLinha);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(241, 80);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configurações Atuais";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(90, 5);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(115, 17);
            this.lbOperador.TabIndex = 19;
            this.lbOperador.Text = "Operador: Bruno";
            // 
            // lbCanal
            // 
            this.lbCanal.AutoSize = true;
            this.lbCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanal.Location = new System.Drawing.Point(10, 5);
            this.lbCanal.Name = "lbCanal";
            this.lbCanal.Size = new System.Drawing.Size(60, 17);
            this.lbCanal.TabIndex = 18;
            this.lbCanal.Text = "Canal: 1";
            // 
            // lbCard
            // 
            this.lbCard.AutoSize = true;
            this.lbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCard.Location = new System.Drawing.Point(10, 29);
            this.lbCard.Name = "lbCard";
            this.lbCard.Size = new System.Drawing.Size(62, 17);
            this.lbCard.TabIndex = 17;
            this.lbCard.Text = "Card: 11";
            // 
            // lbPosto
            // 
            this.lbPosto.AutoSize = true;
            this.lbPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosto.Location = new System.Drawing.Point(10, 55);
            this.lbPosto.Name = "lbPosto";
            this.lbPosto.Size = new System.Drawing.Size(69, 17);
            this.lbPosto.TabIndex = 16;
            this.lbPosto.Text = "Posto: P1";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(90, 55);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(146, 17);
            this.lbModelo.TabIndex = 15;
            this.lbModelo.Text = "Modelo: KD-49X705G";
            // 
            // lbLinha
            // 
            this.lbLinha.AutoSize = true;
            this.lbLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinha.Location = new System.Drawing.Point(90, 29);
            this.lbLinha.Name = "lbLinha";
            this.lbLinha.Size = new System.Drawing.Size(87, 17);
            this.lbLinha.TabIndex = 14;
            this.lbLinha.Text = "Linha: LCM7";
            // 
            // lblfeedback
            // 
            this.lblfeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblfeedback.Location = new System.Drawing.Point(12, 147);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(249, 44);
            this.lblfeedback.TabIndex = 8;
            this.lblfeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConfigurar
            // 
            this.btConfigurar.Location = new System.Drawing.Point(87, 9);
            this.btConfigurar.Name = "btConfigurar";
            this.btConfigurar.Size = new System.Drawing.Size(94, 23);
            this.btConfigurar.TabIndex = 9;
            this.btConfigurar.Text = "CONFIGURAR";
            this.btConfigurar.UseVisualStyleBackColor = true;
            this.btConfigurar.Click += new System.EventHandler(this.btConfigurar_Click);
            // 
            // tmrLabelCronometro
            // 
            this.tmrLabelCronometro.Enabled = true;
            this.tmrLabelCronometro.Interval = 1;
            this.tmrLabelCronometro.Tick += new System.EventHandler(this.tmrLabelCronometro_Tick);
            // 
            // tmrReadAllInputs
            // 
            this.tmrReadAllInputs.Enabled = true;
            this.tmrReadAllInputs.Interval = 1;
            this.tmrReadAllInputs.Tick += new System.EventHandler(this.tmrReadAllInputs_Tick);
            // 
            // Cronometrod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(268, 200);
            this.Controls.Add(this.btConfigurar);
            this.Controls.Add(this.lblfeedback);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cronometrod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cronometragem";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.ListView StateOperlv;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label lbCanal;
        private System.Windows.Forms.Label lbCard;
        private System.Windows.Forms.Label lbPosto;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbLinha;
        private System.Windows.Forms.Button btConfigurar;
        private System.Windows.Forms.Timer tmrLabelCronometro;
        private System.Windows.Forms.Timer tmrReadAllInputs;
    }
}