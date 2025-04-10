namespace ProjetoGerenciador
{
    partial class Inserir
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
            this.dataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.prioridade = new System.Windows.Forms.ComboBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.campoDescricao = new System.Windows.Forms.Label();
            this.campoPrioridade = new System.Windows.Forms.Label();
            this.adicionar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.verTarefa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataVencimento
            // 
            this.dataVencimento.Location = new System.Drawing.Point(357, 167);
            this.dataVencimento.Margin = new System.Windows.Forms.Padding(4);
            this.dataVencimento.Mask = "00/00/0000";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(85, 22);
            this.dataVencimento.TabIndex = 4;
            this.dataVencimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dataVencimento_MaskInputRejected);
            // 
            // prioridade
            // 
            this.prioridade.FormattingEnabled = true;
            this.prioridade.Items.AddRange(new object[] {
            "1.Baixa",
            "2.Média",
            "3.Alta"});
            this.prioridade.Location = new System.Drawing.Point(357, 222);
            this.prioridade.Margin = new System.Windows.Forms.Padding(4);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(256, 24);
            this.prioridade.TabIndex = 6;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(357, 69);
            this.titulo.Margin = new System.Windows.Forms.Padding(4);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(203, 22);
            this.titulo.TabIndex = 7;
            this.titulo.TextChanged += new System.EventHandler(this.titulo_TextChanged);
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(357, 116);
            this.Descricao.Margin = new System.Windows.Forms.Padding(4);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(243, 22);
            this.Descricao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campoDescricao
            // 
            this.campoDescricao.AutoSize = true;
            this.campoDescricao.Location = new System.Drawing.Point(265, 116);
            this.campoDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(72, 16);
            this.campoDescricao.TabIndex = 10;
            this.campoDescricao.Text = "Descriçãoi";
            // 
            // campoPrioridade
            // 
            this.campoPrioridade.AutoSize = true;
            this.campoPrioridade.Location = new System.Drawing.Point(250, 222);
            this.campoPrioridade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campoPrioridade.Name = "campoPrioridade";
            this.campoPrioridade.Size = new System.Drawing.Size(69, 16);
            this.campoPrioridade.TabIndex = 11;
            this.campoPrioridade.Text = "prioridade";
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(389, 329);
            this.adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(149, 37);
            this.adicionar.TabIndex = 12;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(389, 386);
            this.voltar.Margin = new System.Windows.Forms.Padding(4);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(148, 43);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // verTarefa
            // 
            this.verTarefa.Location = new System.Drawing.Point(387, 437);
            this.verTarefa.Margin = new System.Windows.Forms.Padding(4);
            this.verTarefa.Name = "verTarefa";
            this.verTarefa.Size = new System.Drawing.Size(152, 42);
            this.verTarefa.TabIndex = 14;
            this.verTarefa.Text = "ver tarefa";
            this.verTarefa.UseVisualStyleBackColor = true;
            this.verTarefa.Click += new System.EventHandler(this.verTarefa_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.verTarefa);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.campoPrioridade);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.prioridade);
            this.Controls.Add(this.dataVencimento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.Inserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox dataVencimento;
        private System.Windows.Forms.ComboBox prioridade;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label campoDescricao;
        private System.Windows.Forms.Label campoPrioridade;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button verTarefa;
    }
}