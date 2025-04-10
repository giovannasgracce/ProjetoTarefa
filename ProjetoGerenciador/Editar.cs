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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjetoGerenciador
{
    public partial class Editar : Form
    {
        DAO edi;
        public Editar()
        {
            edi = new DAO();
            InitializeComponent();
            maskedCodigo.ReadOnly = false;
            titulo.ReadOnly = true;
            descricao.ReadOnly = true;
            comboBox1.Enabled = true;
            maskedTextBox1.ReadOnly = true;
            concluida.Checked = true;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedCodigo.Text);//pegar oq os usuarios digitou
            string tit = titulo.Text;
            string des = descricao.Text;
            DateTime dtVenci;
            bool dataValida = DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out dtVenci);

            if (!dataValida)
            {
                MessageBox.Show("Data inválida! Use o formato dd/MM/yyyy.");
                return;
            }

            string pri = comboBox1.Text;
            string circunstancia;

            if (concluida.Checked)
            {
                circunstancia = "Concluída";
            }
            else
            {
                circunstancia = "Pendente";
            }

            edi.Editar(codigo, "titulo", tit);
            edi.Editar(codigo, "descricao", des);
            edi.Editar(codigo, "dtVenci", dtVenci.ToString("yyyy-MM-dd"));
            edi.Editar(codigo, "prioridade", pri);
            edi.Editar(codigo, "circunstancia", circunstancia);

            MessageBox.Show("Dados atualizados com sucesso!!");
            this.Close();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void maskedCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void concluida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void procurar_Click(object sender, EventArgs e)
        {
            if (maskedCodigo.Text == "")
            {
                titulo.Text = "Preencha o código";
                descricao.Text = "Preencha o código";
                comboBox1.Text = "Preencha o código";
                maskedTextBox1.Text = "Preencha o código";
                concluida.Checked = false;
            }
            else
            {
                int codigo = Convert.ToInt32(maskedCodigo.Text);

                titulo.Text = edi.RetornarTitulo(codigo);
                descricao.Text = edi.RetornarDescricao(codigo);
                comboBox1.Text = edi.RetornarPrioridade(codigo);
                maskedTextBox1.Text = edi.RetornarData(codigo);

                string status = edi.RetornarCircustancia(codigo); // ← Pega "Concluída" ou "Pendente"
                concluida.Checked = (status == "Concluída"); // ← Marca só se estiver concluída

                maskedCodigo.ReadOnly = true;
                titulo.ReadOnly = false;
                descricao.ReadOnly = false;
                comboBox1.Enabled = true;
                maskedTextBox1.ReadOnly = false;
            }
        }

    }
}
