namespace ProjetoGerenciador
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.listarTarefa = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.concluida = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(348, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Tarefa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listarTarefa
            // 
            this.listarTarefa.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.listarTarefa.Location = new System.Drawing.Point(348, 146);
            this.listarTarefa.Name = "listarTarefa";
            this.listarTarefa.Size = new System.Drawing.Size(153, 41);
            this.listarTarefa.TabIndex = 1;
            this.listarTarefa.Text = "Listar Tarefa";
            this.listarTarefa.UseVisualStyleBackColor = true;
            this.listarTarefa.Click += new System.EventHandler(this.listarTarefa_Click);
            // 
            // editar
            // 
            this.editar.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.editar.Location = new System.Drawing.Point(348, 241);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(153, 44);
            this.editar.TabIndex = 2;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // concluida
            // 
            this.concluida.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.concluida.Location = new System.Drawing.Point(348, 291);
            this.concluida.Name = "concluida";
            this.concluida.Size = new System.Drawing.Size(156, 46);
            this.concluida.TabIndex = 3;
            this.concluida.Text = "Concluída";
            this.concluida.UseVisualStyleBackColor = true;
            this.concluida.Click += new System.EventHandler(this.concluida_Click);
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.excluir.Location = new System.Drawing.Point(349, 348);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(151, 43);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Ebrima", 10.25F, System.Drawing.FontStyle.Bold);
            this.sair.Location = new System.Drawing.Point(349, 397);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(151, 48);
            this.sair.TabIndex = 5;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 140);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(342, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu Principal";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.concluida);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listarTarefa);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button listarTarefa;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button concluida;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}