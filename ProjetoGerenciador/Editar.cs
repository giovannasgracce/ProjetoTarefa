using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DateTime dtVenci = DateTime.Parse(maskedTextBox1.Text);
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
                concluida.Text = "Preencha o código";
            }
            else
            {


                int codigo = Convert.ToInt32(maskedCodigo.Text);//Coletando o código

                titulo.Text = edi.RetornarTitulo(codigo);//Preenchendo o campo titulo
                descricao.Text = edi.RetornarDescricao(codigo);//Preenchendo o campo descricao
                comboBox1.Text = edi.RetornarPrioridade(codigo);//Preenchendo o campo prioridade
                maskedTextBox1.Text = edi.RetornarData(codigo);//Preenchendo o campo data
                concluida.Text = edi.RetornarCircustancia(codigo);//Preenchendo o campo circustancia


                maskedCodigo.ReadOnly = true;// deixa apenas leitura
                titulo.ReadOnly = false;
                descricao.ReadOnly = false;
                comboBox1.Enabled = true;
                maskedTextBox1.ReadOnly = false;
                concluida.Checked = false;
            }
        }
    }
}
