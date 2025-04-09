namespace ProjetoGerenciador
{
    partial class Listar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtrarTudo = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.priori = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // filtrarTudo
            // 
            this.filtrarTudo.Location = new System.Drawing.Point(403, 413);
            this.filtrarTudo.Name = "filtrarTudo";
            this.filtrarTudo.Size = new System.Drawing.Size(140, 32);
            this.filtrarTudo.TabIndex = 1;
            this.filtrarTudo.Text = "Filtrar";
            this.filtrarTudo.UseVisualStyleBackColor = true;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(257, 413);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(104, 31);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // priori
            // 
            this.priori.FormattingEnabled = true;
            this.priori.Items.AddRange(new object[] {
            "1.Baixa",
            "2.Média",
            "3.Alta",
            "4.todos"});
            this.priori.Location = new System.Drawing.Point(423, 12);
            this.priori.Name = "priori";
            this.priori.Size = new System.Drawing.Size(174, 24);
            this.priori.TabIndex = 3;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "1.pendente",
            "2.concluida",
            "3.todos"});
            this.status.Location = new System.Drawing.Point(216, 12);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(145, 24);
            this.status.TabIndex = 4;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.priori);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.filtrarTudo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button filtrarTudo;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ComboBox priori;
        private System.Windows.Forms.ComboBox status;
    }
}