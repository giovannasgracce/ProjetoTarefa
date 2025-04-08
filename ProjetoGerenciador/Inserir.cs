using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ProjetoGerenciador
{
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe DAO
            DAO inserir = new DAO(); // chamando a classe DAO 
            //Coelntando os dados dos campos
            int cod = Convert.ToInt32(codigo.Text);
            string tit = titulo.Text;
            string des = Descricao.Text;
            DateTime dtVenci = DateTime.Parse(dataVencimento.Text);
            string pri = prioridade.Text;
            string circunstancia = "Pendente";

            //chamando o método Inserir
            MessageBox.Show(inserir.Inserir(cod, tit, des, dtVenci,pri, circunstancia));
            this.Close();//Fechar a janela cadastrar
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verTarefa_Click(object sender, EventArgs e)
        {
            Listar lis = new Listar();
            lis.ShowDialog();
        }

        private void codigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void titulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
