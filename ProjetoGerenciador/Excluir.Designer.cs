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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir));
            this.FazerExcluir = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.codigo1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FazerExcluir
            // 
            this.FazerExcluir.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.FazerExcluir.Location = new System.Drawing.Point(272, 238);
            this.FazerExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FazerExcluir.Name = "FazerExcluir";
            this.FazerExcluir.Size = new System.Drawing.Size(92, 27);
            this.FazerExcluir.TabIndex = 0;
            this.FazerExcluir.Text = "Excluir";
            this.FazerExcluir.UseVisualStyleBackColor = true;
            this.FazerExcluir.Click += new System.EventHandler(this.FazerExcluir_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.voltar.Location = new System.Drawing.Point(272, 269);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(92, 32);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // codigo1
            // 
            this.codigo1.Location = new System.Drawing.Point(250, 193);
            this.codigo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigo1.Mask = "00000000";
            this.codigo1.Name = "codigo1";
            this.codigo1.Size = new System.Drawing.Size(130, 20);
            this.codigo1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 139);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(280, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Excluir";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.codigo1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.FazerExcluir);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Excluir";
            this.Text = "Excluir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FazerExcluir;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.MaskedTextBox codigo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}