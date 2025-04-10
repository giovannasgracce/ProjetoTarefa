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
    public partial class Concluida : Form
    {
        public Concluida()
        {
            InitializeComponent();
        }

        private void feita_Click(object sender, EventArgs e)
        {
                if (maskedTextBox1.Text == "")
                {
                    MessageBox.Show("Digite o código da tarefa.");
                    return;
                }

                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza que deseja marcar como concluída?",
                    "Confirmar Conclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {
                    int cod = Convert.ToInt32(maskedTextBox1.Text);
                    DAO dao = new DAO();
                    MessageBox.Show(dao.MarcarComoConcluida(cod));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ação cancelada.");
                }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

