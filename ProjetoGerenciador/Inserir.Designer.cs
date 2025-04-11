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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVencimento
            // 
            this.dataVencimento.Location = new System.Drawing.Point(338, 228);
            this.dataVencimento.Mask = "00/00/0000";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(65, 20);
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
            this.prioridade.Location = new System.Drawing.Point(338, 265);
            this.prioridade.Name = "prioridade";
            this.prioridade.Size = new System.Drawing.Size(193, 21);
            this.prioridade.TabIndex = 6;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(337, 152);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(153, 20);
            this.titulo.TabIndex = 7;
            this.titulo.TextChanged += new System.EventHandler(this.titulo_TextChanged);
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(337, 190);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(183, 20);
            this.Descricao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(290, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campoDescricao
            // 
            this.campoDescricao.AutoSize = true;
            this.campoDescricao.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.campoDescricao.Location = new System.Drawing.Point(268, 195);
            this.campoDescricao.Name = "campoDescricao";
            this.campoDescricao.Size = new System.Drawing.Size(61, 15);
            this.campoDescricao.TabIndex = 10;
            this.campoDescricao.Text = "Descrição";
            // 
            // campoPrioridade
            // 
            this.campoPrioridade.AutoSize = true;
            this.campoPrioridade.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.campoPrioridade.Location = new System.Drawing.Point(265, 271);
            this.campoPrioridade.Name = "campoPrioridade";
            this.campoPrioridade.Size = new System.Drawing.Size(64, 15);
            this.campoPrioridade.TabIndex = 11;
            this.campoPrioridade.Text = "Prioridade";
            // 
            // adicionar
            // 
            this.adicionar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.adicionar.Location = new System.Drawing.Point(378, 325);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(112, 30);
            this.adicionar.TabIndex = 12;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.voltar.Location = new System.Drawing.Point(378, 361);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(111, 35);
            this.voltar.TabIndex = 13;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // verTarefa
            // 
            this.verTarefa.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.verTarefa.Location = new System.Drawing.Point(376, 402);
            this.verTarefa.Name = "verTarefa";
            this.verTarefa.Size = new System.Drawing.Size(114, 34);
            this.verTarefa.TabIndex = 14;
            this.verTarefa.Text = "Ver Tarefa";
            this.verTarefa.UseVisualStyleBackColor = true;
            this.verTarefa.Click += new System.EventHandler(this.verTarefa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 140);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(208, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data de Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(384, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Inserir";
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.Inserir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}