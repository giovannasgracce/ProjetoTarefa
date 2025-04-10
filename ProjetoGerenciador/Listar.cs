using ProjetoGerenciador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
   
            status.Items.AddRange(new string[] { "Todos", "Pendente", "Concluída" });
            priori.Items.AddRange(new string[] { "Todas", "Alta", "Média", "Baixa" });


            status.SelectedIndex = 0;
            priori.SelectedIndex = 0;

            // Adiciona evento para filtrar quando mudar seleção
            status.SelectedIndexChanged += (s, e) => { Filtrar(); DestacarDatas(); };
            priori.SelectedIndexChanged += (s, e) => { Filtrar(); DestacarDatas(); };
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

            DestacarDatas(); // coloca as cores ao carregar
        }

        private void Filtrar()
        {
            string statusSelecionado = status.Text.Trim().ToLower();
            string prioridadeSelecionada = priori.Text.Trim().ToLower();
            string tituloDigitado = RemoverAcentos(Pesquisa.Text.Trim().ToLower());

            dataGridView1.Rows.Clear();
            lis.PreencherVetor();

            for (int i = 0; i < lis.QuantidadeDeDados(); i++)
            {
                string statusVetor = lis.circunstancia[i].Trim().ToLower();
                string prioridadeVetor = lis.prioridade[i].Trim().ToLower();
                string tituloVetor = RemoverAcentos(lis.titulo[i].Trim().ToLower());

                bool statusOK = (statusSelecionado == "todos" || statusSelecionado == statusVetor);
                string prioridadeTratada = prioridadeVetor.Split('.')[1];
                bool prioridadeOK = (prioridadeSelecionada == "todas" || prioridadeSelecionada == prioridadeTratada);
                bool tituloOK = string.IsNullOrEmpty(tituloDigitado) || tituloVetor.Contains(tituloDigitado);

                if (statusOK && prioridadeOK && tituloOK)
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




        private void DestacarDatas()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null) // Coluna 4 = "Data Vencimento"
                {
                    DateTime dtVenci;
                    if (DateTime.TryParse(row.Cells[4].Value.ToString(), out dtVenci))
                    {
                        double dias = (dtVenci - DateTime.Today).TotalDays;

                        if (dias <= 3 && dias >= -3)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
                        }
                        else if (dias < -3)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
                        }
                    }
                  
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // esse evento não precisa mais destacar, pois já está no DestacarDatas
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filtrarTudo_Click(object sender, EventArgs e)
        {
            Filtrar();
            DestacarDatas();
        }

        private string RemoverAcentos(string texto)
        {
            return new string(texto
                .Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }

        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {
                Filtrar();
                DestacarDatas(); 
        }

        private void GerarRelatorio()
        {
            lis.PreencherVetor();

            Dictionary<string, int> contagemStatus = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            Dictionary<string, int> contagemPrioridade = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            for (int i = 0; i < lis.QuantidadeDeDados(); i++)
            {
                string status = lis.circunstancia[i].Trim();
                string prioridade = lis.prioridade[i].Trim().Split('.')[1]; // pega só 'alta', 'média', etc.

                if (contagemStatus.ContainsKey(status))
                    contagemStatus[status]++;
                else
                    contagemStatus[status] = 1;

                if (contagemPrioridade.ContainsKey(prioridade))
                    contagemPrioridade[prioridade]++;
                else
                    contagemPrioridade[prioridade] = 1;
            }

            // Monta o texto do relatório
            StringBuilder relatorio = new StringBuilder();

            relatorio.AppendLine("📊 RELATÓRIO DE TAREFAS 📊\n");

            relatorio.AppendLine("✅ Quantidade por Status:");
            foreach (var item in contagemStatus)
            {
                relatorio.AppendLine($"- {item.Key}: {item.Value}");
            }

            relatorio.AppendLine("\n🚦 Quantidade por Prioridade:");
            foreach (var item in contagemPrioridade)
            {
                relatorio.AppendLine($"- {item.Key}: {item.Value}");
            }

            MessageBox.Show(relatorio.ToString(), "Relatório Estatístico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void gerarRelatorio_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}// aviso sobre a tabela : fica colorida no atraso


