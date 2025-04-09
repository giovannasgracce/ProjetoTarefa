using ProjetoGerenciador;
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
    public partial class Listar : Form
    {
        DAO lis;

        public Listar()
        {
            lis = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();
            CriarFiltros();
            AdicionarDados();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
        }

        public void CriarFiltros()
        {
            status.SelectedIndex = 0; // primeira opção selecionada
            status.SelectedIndexChanged += (s, e) => Filtrar(); // quando mudar, chama o filtro

            priori.SelectedIndex = 0;
            priori.SelectedIndexChanged += (s, e) => Filtrar();
        }

        public void NomeColunas()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Título";
            dataGridView1.Columns[2].Name = "Descrição";
            dataGridView1.Columns[3].Name = "Prioridade";
            dataGridView1.Columns[4].Name = "Data Vencimento";
            dataGridView1.Columns[5].Name = "Status";
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        public void AdicionarDados()
        {
            dataGridView1.Rows.Clear();
            lis.PreencherVetor();

            for (int i = 0; i < lis.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(
                    lis.codigo[i],
                    lis.titulo[i],
                    lis.descricao[i],
                    lis.prioridade[i],
                    lis.dtVenci[i].ToShortDateString(),
                    lis.circunstancia[i]);
            }
        }

        private void Filtrar()
        {
            string statusSelecionado = status.Text;
            string prioridadeSelecionada = priori.Text;

            dataGridView1.Rows.Clear();
            lis.PreencherVetor();

            for (int i = 0; i < lis.QuantidadeDeDados(); i++)
            {
                bool statusOK = (statusSelecionado == "Todos" || lis.circunstancia[i] == statusSelecionado);
                bool prioridadeOK = (prioridadeSelecionada == "Todas" || lis.prioridade[i] == prioridadeSelecionada);

                if (statusOK && prioridadeOK)
                {
                    dataGridView1.Rows.Add(
                        lis.codigo[i],
                        lis.titulo[i],
                        lis.descricao[i],
                        lis.prioridade[i],
                        lis.dtVenci[i].ToShortDateString(),
                        lis.circunstancia[i]);
                } 
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Data Vencimento")
            {
                DateTime data = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if ((data - DateTime.Today).TotalDays <= 3)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}


