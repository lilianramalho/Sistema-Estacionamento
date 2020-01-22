namespace Estacionamento
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.nome = new System.Windows.Forms.Label();
            this.nomecliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cpfcliente = new System.Windows.Forms.TextBox();
            this.logradourocliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numerorescliente = new System.Windows.Forms.TextBox();
            this.rg = new System.Windows.Forms.Label();
            this.rgcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cidadecliente = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.nome.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(154, 143);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(66, 28);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // nomecliente
            // 
            this.nomecliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomecliente.Location = new System.Drawing.Point(226, 145);
            this.nomecliente.Name = "nomecliente";
            this.nomecliente.Size = new System.Drawing.Size(289, 29);
            this.nomecliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // cpfcliente
            // 
            this.cpfcliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfcliente.Location = new System.Drawing.Point(609, 145);
            this.cpfcliente.Name = "cpfcliente";
            this.cpfcliente.Size = new System.Drawing.Size(136, 29);
            this.cpfcliente.TabIndex = 3;
            // 
            // logradourocliente
            // 
            this.logradourocliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logradourocliente.Location = new System.Drawing.Point(286, 244);
            this.logradourocliente.Name = "logradourocliente";
            this.logradourocliente.Size = new System.Drawing.Size(243, 29);
            this.logradourocliente.TabIndex = 4;
            this.logradourocliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label2.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logradouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label3.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "N°";
            // 
            // numerorescliente
            // 
            this.numerorescliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerorescliente.Location = new System.Drawing.Point(609, 241);
            this.numerorescliente.Name = "numerorescliente";
            this.numerorescliente.Size = new System.Drawing.Size(99, 29);
            this.numerorescliente.TabIndex = 7;
            this.numerorescliente.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.rg.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(154, 197);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(38, 28);
            this.rg.TabIndex = 13;
            this.rg.Text = "RG";
            // 
            // rgcliente
            // 
            this.rgcliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgcliente.Location = new System.Drawing.Point(247, 199);
            this.rgcliente.Name = "rgcliente";
            this.rgcliente.Size = new System.Drawing.Size(243, 29);
            this.rgcliente.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label5.Font = new System.Drawing.Font("Antaro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cidade";
            // 
            // cidadecliente
            // 
            this.cidadecliente.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadecliente.Location = new System.Drawing.Point(609, 199);
            this.cidadecliente.Name = "cidadecliente";
            this.cidadecliente.Size = new System.Drawing.Size(136, 29);
            this.cidadecliente.TabIndex = 16;
            this.cidadecliente.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Salvar.Image")));
            this.Salvar.Location = new System.Drawing.Point(701, 454);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(44, 47);
            this.Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salvar.TabIndex = 17;
            this.Salvar.TabStop = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label6.Font = new System.Drawing.Font("Antaro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(389, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Novo Cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 120);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 629);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.cidadecliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rgcliente);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.numerorescliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logradourocliente);
            this.Controls.Add(this.cpfcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomecliente);
            this.Controls.Add(this.nome);
            this.Font = new System.Drawing.Font("Antaro", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox nomecliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cpfcliente;
        private System.Windows.Forms.TextBox logradourocliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numerorescliente;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.TextBox rgcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cidadecliente;
        private System.Windows.Forms.PictureBox Salvar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

