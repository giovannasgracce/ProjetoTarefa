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
            this.codigo = new System.Windows.Forms.MaskedTextBox();
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
            this.dataVencimento.Location = new System.Drawing.Point(268, 136);
            this.dataVencimento.Mask = "00/00/0000";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(65, 20);
            this.dataVencimento.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(268, 177);
            this.codigo.Mask = "00000";
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(156, 20);
            this.codigo.TabIndex = 5;
            this.codigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.codigo_MaskInputRejected);
            // 
            // prioridade
            // 
            this.prioridade.FormattingEnabled = true;
            this.prioridade.Items.AddRange(new object[] {
            "1.Baixa",
            "2.Média",
            "3.Alta"});
            this.prioridade.Location = new System.Drawing.Point(268, 218);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(193, 21);
            this.prioridade.TabIndex = 6;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(268, 56);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(153, 20);
            this.titulo.TabIndex = 7;
            this.titulo.TextChanged += new System.EventHandler(this.titulo_TextChanged);
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(268, 94);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(183, 20);
            this.Descricao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campoDescricao
            // 
            this.campoDescricao.AutoSize = true;
            this.campoDescricao.Location = new System.Drawing.Point(199, 94);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(57, 13);
            this.campoDescricao.TabIndex = 10;
            this.campoDescricao.Text = "Descriçãoi";
            // 
            // campoPrioridade
            // 
            this.campoPrioridade.AutoSize = true;
            this.campoPrioridade.Location = new System.Drawing.Point(199, 218);
            this.campoPrioridade.Name = "campoPrioridade";
            this.campoPrioridade.Size = new System.Drawing.Size(53, 13);
            this.campoPrioridade.TabIndex = 11;
            this.campoPrioridade.Text = "prioridade";
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(292, 267);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(112, 30);
            this.adicionar.TabIndex = 12;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(292, 314);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(111, 35);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // verTarefa
            // 
            this.verTarefa.Location = new System.Drawing.Point(290, 355);
            this.verTarefa.Name = "verTarefa";
            this.verTarefa.Size = new System.Drawing.Size(114, 34);
            this.verTarefa.TabIndex = 14;
            this.verTarefa.Text = "ver tarefa";
            this.verTarefa.UseVisualStyleBackColor = true;
            this.verTarefa.Click += new System.EventHandler(this.verTarefa_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verTarefa);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.campoPrioridade);
            this.Controls.Add(this.campoDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.prioridade);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.dataVencimento);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox dataVencimento;
        private System.Windows.Forms.MaskedTextBox codigo;
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