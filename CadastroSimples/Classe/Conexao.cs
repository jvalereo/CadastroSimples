using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;

namespace CadastroSimples.Classe
{
    //Projeto - Sistema Básico de Cadastro Simples
    //Sistema, cadastrar enviar dados para o banco de dados
    //Jonas Valereo - Técnico em Informática
    //Data: 15/02/2013
    class Conexao
    {
        //conexao com banco de dados
        string conexao = "Data Source=JONAS;Initial Catalog=formulario;Persist Security Info=True; User ID=sa; Password=030577";

        //metodo para gravar dados
        public int Cadastrar(String nome, String sobrenome, String celular)
        {
            int retorno = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string sqlIncluir = "insert into usuario(nome,sobrenome,celular)values('" + nome + "','" + sobrenome + "', '" + celular + "')";

            conn.Open();

            SqlCommand cmd = new SqlCommand(sqlIncluir, conn);
            retorno = (int)cmd.ExecuteNonQuery();

            return retorno;

        }

        //metodo para alterar dados
        public int Alterar(int id_usar, String nome, String sobrenome, String celular)
        {
            int retornoAlterar = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string sqlAlterar = "update usuario set  id_usar='" + id_usar + "', nome='" + nome + "', sobrenome='" + sobrenome + "', celular='" + celular + "'";

            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlAlterar, conn);

            retornoAlterar = (int)cmd.ExecuteNonQuery();

            return retornoAlterar;
        }

         //Fim da classe conexao
    }

}
