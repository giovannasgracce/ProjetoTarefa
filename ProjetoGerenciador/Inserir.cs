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
            // Instanciando a classe DAO
            DAO inserir = new DAO();

            // Coletando os dados dos campos
            string tit = titulo.Text;
            string des = Descricao.Text;
            DateTime dtVenci;

            bool dataValida = DateTime.TryParseExact(
                dataVencimento.Text,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out dtVenci);

            if (!dataValida)
            {
                MessageBox.Show("Data inválida! Use o formato dd/MM/yyyy.");
                return;
            }

            string pri = prioridade.Text;
            string circunstancia = "Pendente";

            // Chamando o método Inserir (sem código agora!)
            MessageBox.Show(inserir.Inserir(tit, des, dtVenci, pri, circunstancia));
            this.Close(); // Fechar a janela cadastrar
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

        private void dataVencimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }
    }
}
