namespace ProjetoGerenciador
{
    partial class Excluir
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
            this.FazerExcluir = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.codigo1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // FazerExcluir
            // 
            this.FazerExcluir.Location = new System.Drawing.Point(379, 188);
            this.FazerExcluir.Name = "FazerExcluir";
            this.FazerExcluir.Size = new System.Drawing.Size(123, 33);
            this.FazerExcluir.TabIndex = 0;
            this.FazerExcluir.Text = "excluir";
            this.FazerExcluir.UseVisualStyleBackColor = true;
            this.FazerExcluir.Click += new System.EventHandler(this.FazerExcluir_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(378, 247);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(123, 39);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // codigo1
            // 
            this.codigo1.Location = new System.Drawing.Point(352, 99);
            this.codigo1.Mask = "00000000";
            this.codigo1.Name = "codigo1";
            this.codigo1.Size = new System.Drawing.Size(172, 22);
            this.codigo1.TabIndex = 2;
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigo1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.FazerExcluir);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FazerExcluir;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.MaskedTextBox codigo1;
    }
}