namespace Estacionamento
{
    partial class Cargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargos));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Salvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.label6.Font = new System.Drawing.Font("Antaro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(214, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Novo Cargo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Antaro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(143, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 29);
            this.textBox1.TabIndex = 21;
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Salvar.Image")));
            this.Salvar.Location = new System.Drawing.Point(388, 238);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(44, 47);
            this.Salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salvar.TabIndex = 22;
            this.Salvar.TabStop = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(546, 338);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Name = "Cargos";
            this.Text = "Cargos";
            ((System.ComponentModel.ISupportInitialize)(this.Salvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox Salvar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}