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
            this.button1 = new System.Windows.Forms.Button();
            this.listarTarefa = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.concluida = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir Tarefa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listarTarefa
            // 
            this.listarTarefa.Location = new System.Drawing.Point(307, 61);
            this.listarTarefa.Name = "listarTarefa";
            this.listarTarefa.Size = new System.Drawing.Size(153, 41);
            this.listarTarefa.TabIndex = 1;
            this.listarTarefa.Text = "Listar Tarefa";
            this.listarTarefa.UseVisualStyleBackColor = true;
            this.listarTarefa.Click += new System.EventHandler(this.listarTarefa_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(304, 156);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(153, 44);
            this.editar.TabIndex = 2;
            this.editar.Text = "editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // concluida
            // 
            this.concluida.Location = new System.Drawing.Point(304, 206);
            this.concluida.Name = "concluida";
            this.concluida.Size = new System.Drawing.Size(156, 46);
            this.concluida.TabIndex = 3;
            this.concluida.Text = "concluida";
            this.concluida.UseVisualStyleBackColor = true;
            this.concluida.Click += new System.EventHandler(this.concluida_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(306, 263);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(151, 43);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(304, 312);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(151, 48);
            this.sair.TabIndex = 5;
            this.sair.Text = "sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.concluida);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.listarTarefa);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button listarTarefa;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button concluida;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button sair;
    }
}