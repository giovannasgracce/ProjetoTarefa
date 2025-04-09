using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGerenciador
{
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void FazerExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(codigo1.Text);
                MessageBox.Show(exc.Excluir(codigo));
                this.Close(); // Fecha a tela após excluir
            }
            else
            {
                MessageBox.Show("Exclusão cancelada.");
            }

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
