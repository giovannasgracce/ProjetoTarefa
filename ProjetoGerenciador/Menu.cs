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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)//Inserir tarefa
        {
            Inserir ins = new Inserir();
            ins.ShowDialog();
        }

        private void listarTarefa_Click(object sender, EventArgs e)
        {
            Listar lis = new Listar();
            lis.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Editar edi = new Editar();
            edi.ShowDialog();
        }

        private void concluida_Click(object sender, EventArgs e)
        {
            Concluida con = new Concluida();
            con.ShowDialog();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
