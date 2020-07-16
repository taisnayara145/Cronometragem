namespace Cronometro
{
    partial class Setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCanal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbLinha;
        private System.Windows.Forms.ComboBox cbPosto;
        private System.Windows.Forms.ComboBox cbModelo;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCanal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbLinha = new System.Windows.Forms.ComboBox();
            this.cbPosto = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.tbOperador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canal:";
            // 
            // tbCanal
            // 
            this.tbCanal.Location = new System.Drawing.Point(81, 28);
            this.tbCanal.Name = "tbCanal";
            this.tbCanal.Size = new System.Drawing.Size(138, 20);
            this.tbCanal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card:";
            // 
            // tbPorta
            // 
            this.tbPorta.Location = new System.Drawing.Point(81, 64);
            this.tbPorta.Name = "tbPorta";
            this.tbPorta.Size = new System.Drawing.Size(138, 20);
            this.tbPorta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Linha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Posto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modelo:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(97, 240);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbLinha
            // 
            this.cbLinha.FormattingEnabled = true;
            this.cbLinha.Location = new System.Drawing.Point(81, 135);
            this.cbLinha.Name = "cbLinha";
            this.cbLinha.Size = new System.Drawing.Size(138, 21);
            this.cbLinha.TabIndex = 11;
            // 
            // cbPosto
            // 
            this.cbPosto.FormattingEnabled = true;
            this.cbPosto.Location = new System.Drawing.Point(81, 170);
            this.cbPosto.Name = "cbPosto";
            this.cbPosto.Size = new System.Drawing.Size(138, 21);
            this.cbPosto.TabIndex = 12;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(81, 203);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(138, 21);
            this.cbModelo.TabIndex = 13;
            // 
            // tbOperador
            // 
            this.tbOperador.Location = new System.Drawing.Point(81, 102);
            this.tbOperador.Name = "tbOperador";
            this.tbOperador.Size = new System.Drawing.Size(138, 20);
            this.tbOperador.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Operador:";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 285);
            this.Controls.Add(this.tbOperador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbPosto);
            this.Controls.Add(this.cbLinha);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCanal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOperador;
        private System.Windows.Forms.Label label6;

        public System.Windows.Forms.TextBox txtCanal
        {
            get { return tbCanal; }
        }

        public System.Windows.Forms.TextBox txtPorta
        {
            get { return tbPorta; }
        }

        public System.Windows.Forms.ComboBox comboLinha
        {
            get { return cbLinha; }
        }

        public System.Windows.Forms.ComboBox comboPosto
        {
            get { return cbPosto; }
        }

        public System.Windows.Forms.ComboBox comboModelo
        {
            get { return cbModelo; }
        }


    }
}