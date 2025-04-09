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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.feita = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(303, 77);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(181, 22);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // feita
            // 
            this.feita.Location = new System.Drawing.Point(329, 124);
            this.feita.Name = "feita";
            this.feita.Size = new System.Drawing.Size(137, 38);
            this.feita.TabIndex = 1;
            this.feita.Text = "Concluida";
            this.feita.UseVisualStyleBackColor = true;
            this.feita.Click += new System.EventHandler(this.feita_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(329, 184);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(137, 43);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // Concluida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.feita);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Concluida";
            this.Text = "Concluida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button feita;
        private System.Windows.Forms.Button voltar;
    }
}