﻿namespace ProjetoGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.Button();
            this.priori = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.gerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.voltar.Location = new System.Drawing.Point(9, 331);
            this.voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(78, 25);
            this.voltar.TabIndex = 2;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // priori
            // 
            this.priori.FormattingEnabled = true;
            this.priori.Location = new System.Drawing.Point(9, 14);
            this.priori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priori.Name = "priori";
            this.priori.Size = new System.Drawing.Size(110, 21);
            this.priori.TabIndex = 3;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(9, 38);
            this.status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(110, 21);
            this.status.TabIndex = 4;
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(263, 19);
            this.Pesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(305, 20);
            this.Pesquisa.TabIndex = 5;
            this.Pesquisa.TextChanged += new System.EventHandler(this.Pesquisa_TextChanged);
            // 
            // gerarRelatorio
            // 
            this.gerarRelatorio.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.gerarRelatorio.Location = new System.Drawing.Point(477, 41);
            this.gerarRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gerarRelatorio.Name = "gerarRelatorio";
            this.gerarRelatorio.Size = new System.Drawing.Size(91, 29);
            this.gerarRelatorio.TabIndex = 6;
            this.gerarRelatorio.Text = "Relatório";
            this.gerarRelatorio.UseVisualStyleBackColor = true;
            this.gerarRelatorio.Click += new System.EventHandler(this.gerarRelatorio_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gerarRelatorio);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.status);
            this.Controls.Add(this.priori);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ComboBox priori;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.Button gerarRelatorio;
    }
}