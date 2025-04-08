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

        public string Inserir(int codigo, string titulo, string descricao, DateTime dtVenci, string prioridade, string circunstancia)//Inserir no banco todos os inserir são assim
        {
            string inserir = $"Insert into tarefa(codigo,titulo,descricao,dtVenci,prioridade,circunstancia) values('{codigo}','{titulo}','{descricao}','{dtVenci:yyyy-MM-dd}','{prioridade}','{circunstancia}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;
        }//fim do metodo inserir

    }
}
