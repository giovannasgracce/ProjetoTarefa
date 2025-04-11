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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoEditar
            // 
            this.botaoEditar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.botaoEditar.Location = new System.Drawing.Point(254, 297);
            this.botaoEditar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(91, 30);
            this.botaoEditar.TabIndex = 0;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.voltar.Location = new System.Drawing.Point(253, 329);
            this.voltar.Margin = new System.Windows.Forms.Padding(2);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(94, 35);
            this.voltar.TabIndex = 1;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(266, 131);
            this.titulo.Margin = new System.Windows.Forms.Padding(2);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(96, 20);
            this.titulo.TabIndex = 2;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(266, 164);
            this.descricao.Margin = new System.Windows.Forms.Padding(2);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(96, 20);
            this.descricao.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.Baixa",
            "2.Média",
            "3.Alta"});
            this.comboBox1.Location = new System.Drawing.Point(266, 195);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(266, 226);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(213, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
            // 
            // maskedCodigo
            // 
            this.maskedCodigo.Location = new System.Drawing.Point(266, 97);
            this.maskedCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.maskedCodigo.Mask = "0000000";
            this.maskedCodigo.Name = "maskedCodigo";
            this.maskedCodigo.Size = new System.Drawing.Size(89, 20);
            this.maskedCodigo.TabIndex = 8;
            this.maskedCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCodigo_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo";
            // 
            // procurar
            // 
            this.procurar.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold);
            this.procurar.Location = new System.Drawing.Point(370, 94);
            this.procurar.Margin = new System.Windows.Forms.Padding(2);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(65, 23);
            this.procurar.TabIndex = 10;
            this.procurar.Text = "Procurar";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // concluida
            // 
            this.concluida.AutoSize = true;
            this.concluida.Location = new System.Drawing.Point(268, 265);
            this.concluida.Margin = new System.Windows.Forms.Padding(2);
            this.concluida.Name = "concluida";
            this.concluida.Size = new System.Drawing.Size(54, 17);
            this.concluida.TabIndex = 11;
            this.concluida.Text = "status";
            this.concluida.UseVisualStyleBackColor = true;
            this.concluida.CheckedChanged += new System.EventHandler(this.concluida_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 140);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(275, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "Editar";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Editar";
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}