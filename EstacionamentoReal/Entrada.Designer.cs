namespace Estacionamento
{
    partial class Entrada
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carroCarro = new System.Windows.Forms.TextBox();
            this.modeloCarro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.corCarro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataCarro = new System.Windows.Forms.MaskedTextBox();
            this.horaCarro = new System.Windows.Forms.MaskedTextBox();
            this.placaEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Modelo";
            // 
            // carroCarro
            // 
            this.carroCarro.Location = new System.Drawing.Point(74, 160);
            this.carroCarro.Name = "carroCarro";
            this.carroCarro.Size = new System.Drawing.Size(278, 20);
            this.carroCarro.TabIndex = 8;
            // 
            // modeloCarro
            // 
            this.modeloCarro.Location = new System.Drawing.Point(74, 196);
            this.modeloCarro.Name = "modeloCarro";
            this.modeloCarro.Size = new System.Drawing.Size(121, 20);
            this.modeloCarro.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(74, 119);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(278, 21);
            this.comboCliente.TabIndex = 12;
            this.comboCliente.SelectedIndexChanged += new System.EventHandler(this.comboCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cor";
            // 
            // corCarro
            // 
            this.corCarro.Location = new System.Drawing.Point(252, 196);
            this.corCarro.Name = "corCarro";
            this.corCarro.Size = new System.Drawing.Size(100, 20);
            this.corCarro.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataCarro
            // 
            this.dataCarro.Location = new System.Drawing.Point(74, 74);
            this.dataCarro.Mask = "00/00/0000";
            this.dataCarro.Name = "dataCarro";
            this.dataCarro.Size = new System.Drawing.Size(100, 20);
            this.dataCarro.TabIndex = 16;
            this.dataCarro.ValidatingType = typeof(System.DateTime);
            // 
            // horaCarro
            // 
            this.horaCarro.Location = new System.Drawing.Point(252, 74);
            this.horaCarro.Mask = "00:00";
            this.horaCarro.Name = "horaCarro";
            this.horaCarro.Size = new System.Drawing.Size(100, 20);
            this.horaCarro.TabIndex = 17;
            this.horaCarro.ValidatingType = typeof(System.DateTime);
            // 
            // placaEntrada
            // 
            this.placaEntrada.AutoSize = true;
            this.placaEntrada.Location = new System.Drawing.Point(149, 31);
            this.placaEntrada.Name = "placaEntrada";
            this.placaEntrada.Size = new System.Drawing.Size(34, 13);
            this.placaEntrada.TabIndex = 18;
            this.placaEntrada.Text = "Placa";
            this.placaEntrada.Click += new System.EventHandler(this.label7_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 344);
            this.Controls.Add(this.placaEntrada);
            this.Controls.Add(this.horaCarro);
            this.Controls.Add(this.dataCarro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.corCarro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modeloCarro);
            this.Controls.Add(this.carroCarro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox carroCarro;
        private System.Windows.Forms.TextBox modeloCarro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox corCarro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox dataCarro;
        private System.Windows.Forms.MaskedTextBox horaCarro;
        private System.Windows.Forms.Label placaEntrada;
    }
}