namespace ProjetoGerenciador
{
    partial class Editar
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
            this.botaoEditar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.procurar = new System.Windows.Forms.Button();
            this.concluida = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(395, 285);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(121, 37);
            this.botaoEditar.TabIndex = 0;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(395, 338);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(126, 43);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(391, 80);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(127, 22);
            this.titulo.TabIndex = 2;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(391, 121);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(127, 22);
            this.descricao.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.Baixa",
            "2.Média",
            "3.Alta"});
            this.comboBox1.Location = new System.Drawing.Point(391, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(392, 197);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(119, 22);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "descriccao";
            // 
            // maskedCodigo
            // 
            this.maskedCodigo.Location = new System.Drawing.Point(395, 35);
            this.maskedCodigo.Mask = "0000000";
            this.maskedCodigo.Name = "maskedCodigo";
            this.maskedCodigo.Size = new System.Drawing.Size(117, 22);
            this.maskedCodigo.TabIndex = 8;
            this.maskedCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCodigo_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "codigo";
            // 
            // procurar
            // 
            this.procurar.Location = new System.Drawing.Point(529, 35);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(75, 21);
            this.procurar.TabIndex = 10;
            this.procurar.Text = "procurar";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // concluida
            // 
            this.concluida.AutoSize = true;
            this.concluida.Location = new System.Drawing.Point(395, 245);
            this.concluida.Name = "concluida";
            this.concluida.Size = new System.Drawing.Size(64, 20);
            this.concluida.TabIndex = 11;
            this.concluida.Text = "status";
            this.concluida.UseVisualStyleBackColor = true;
            this.concluida.CheckedChanged += new System.EventHandler(this.concluida_CheckedChanged);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.concluida);
            this.Controls.Add(this.procurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.botaoEditar);
            this.Name = "Editar";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.CheckBox concluida;
    }
}