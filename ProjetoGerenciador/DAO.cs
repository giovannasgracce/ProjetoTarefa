using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace ProjetoGerenciador
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] titulo;
        public string[] descricao;
        public DateTime[] dtVenci;
        public string[] prioridade;
        public string[] circunstancia;//status
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=projetoTarefa;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar com o banco 
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }// Fim do construtor

        public string Inserir(string titulo, string descricao, DateTime dtVenci, string prioridade, string circunstancia)
        {
            string inserir = $"INSERT INTO tarefa(titulo, descricao, dtVenci, prioridade, circunstancia) " +
                             $"VALUES('{titulo}', '{descricao}', '{dtVenci:yyyy-MM-dd}', '{prioridade}', '{circunstancia}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }




        public void PreencherVetor()//consulta no banco
        {
            string query = "select * from tarefa";
            // Instanciar vetores
            this.codigo = new int[100];
            this.titulo = new string[100];
            this.descricao = new string[100];
            this.dtVenci = new DateTime[100];
            this.prioridade = new string[100];
            this.circunstancia = new string[100];

            // Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);

            // Chamar o leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0; // Contador do vetor
            contador = 0; // Contador total
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                titulo[i] = leitura["titulo"] + "";
                descricao[i] = leitura["descricao"] + "";
                dtVenci[i] = Convert.ToDateTime(leitura["dtVenci"]);
                prioridade[i] = leitura["prioridade"] + "";
                circunstancia[i] = leitura["circunstancia"] + "";
                i++;
                contador++;
            }

            // Encerrar o processo de leitura
            leitura.Close();
        }



            public int ConsultarPorCodigo(int cod)//consulta no banco
        {
            PreencherVetor();//preencehndo vetor com os dados

            i = 0;//Instanciar o i contador
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {

                    return i;

                }
                i++;//contador girar
            }//fim do while

            return -1;

        }//fim do metodo ConsultarPorCodigo

        public string RetornarTitulo(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return titulo[posicao];
            }
            return "Código digitado não é váido";

        }//fim do retornarNome

        public string RetornarDescricao(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Código digitado não é váido";

        }//fim do retornarNome

        public string RetornarPrioridade(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return prioridade[posicao];
            }
            return "Código digitado não é váido";

        }//fim do retornarNome


        public string RetornarData(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return dtVenci[posicao].ToString("dd/MM/yyyy");

            }
            return "Código digitado não é válido";
        }


        public string RetornarCircustancia(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return circunstancia[posicao];
            }
            return "Código digitado não é váido";

        }//fim do retornarNome

        public int QuantidadeDeDados()
        {
            return contador;
        }// fim do QuantidadeDeDados


        public string Editar(int codigo, string campo, string dado)
        {
            string query = $"UPDATE tarefa SET {campo} = @dado WHERE codigo = @codigo";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            sql.Parameters.AddWithValue("@dado", dado);
            sql.Parameters.AddWithValue("@codigo", codigo);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!!";
            return resultado;
        }//fim do atualizar--utiliza so na pessoa// update {nometabela} set ---> utiliza para masi de uma tabela em um unico método


        

        public string Excluir(int codigo)
        {
            string query = $"delete from tarefa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!!";
            return resultado;
        }//fim do Excluir


        public string MarcarComoConcluida(int codigo)
        {
            string query = $"update tarefa set circunstancia = 'Concluída' where codigo = {codigo}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " tarefa marcada como concluída!";
            return resultado;
        }

    }
}
