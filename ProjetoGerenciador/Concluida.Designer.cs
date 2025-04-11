namespace ProjetoGerenciador
{
    partial class Concluida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concluida));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.feita = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(250, 229);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // feita
            // 
            this.feita.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.feita.Location = new System.Drawing.Point(270, 267);
            this.feita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feita.Name = "feita";
            this.feita.Size = new System.Drawing.Size(103, 31);
            this.feita.TabIndex = 1;
            this.feita.Text = "Concluída";
            this.feita.UseVisualStyleBackColor = true;
            this.feita.Click += new System.EventHandler(this.feita_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.voltar.Location = new System.Drawing.Point(270, 301);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(103, 35);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 137);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(265, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Concluída";
            // 
            // Concluida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.feita);
            this.Controls.Add(this.maskedTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Concluida";
            this.Text = "Concluida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button feita;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}