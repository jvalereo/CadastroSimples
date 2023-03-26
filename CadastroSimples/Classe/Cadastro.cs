using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Threading.Tasks;

namespace CadastroSimples.Classe.Cadastro
{
    //Projeto - Sistema Básico de Cadastro Simples
    //Sistema, cadastrar enviar dados para o banco de dados
    //Jonas Valereo - Técnico em Informática
    //Data: 15/02/2013
    class Cadastro
    {
        //conexao com banco de dados
        string conexao = "Data Source=JONAS;Initial Catalog=formulario;Persist Security Info=True; User ID=sa; Password=030577";

        //metodo para gravar dados
       public int gravaDados(String nome, String sobrenome, String celular)
        {
           int retorGrava = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string sqlIncluir = "insert into usuario(nome,sobrenome,celular) values(@nome,@sobrenome,@celular)";
            SqlCommand cmd = new SqlCommand(sqlIncluir, conn);
           
            conn.Open();

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
            cmd.Parameters.AddWithValue("@celular", celular);
        
            retorGrava = (int)cmd.ExecuteNonQuery();

            return retorGrava;
            
        }

        //metodo para alterar dados
        public int alteraDados(int id_usar,String nome, String sobrenome, String celular)
        {
            int retornarAlterar = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string sqlUpd = "update usuario set nome=@nome,sobrenome=@sobrenome,celular=@celular where id_usar=@id_usar";
            SqlCommand cmd = new SqlCommand(sqlUpd, conn);

            cmd.Parameters.Add(new SqlParameter("@id_usar", id_usar));
            cmd.Parameters.Add(new SqlParameter("@nome", nome));
            cmd.Parameters.Add(new SqlParameter("@sobrenome", sobrenome));
            cmd.Parameters.Add(new SqlParameter("@celular", celular));
         
            conn.Open();

            retornarAlterar = (int)cmd.ExecuteNonQuery();

            return retornarAlterar;

        }

        //metodo para alterar dados
        public int excluirDados(int id_usar)
        {
            int excluir = 0;

            SqlConnection conn = new SqlConnection(conexao);
            string delet = "delete from usuario where id_usar='" + id_usar + "'";
            SqlCommand cmd = new SqlCommand(delet, conn);

            conn.Open();

            excluir = (int)cmd.ExecuteNonQuery();

            return excluir;
        }

        //###################### CARREGAGRID S/PARAMETRO ##############################
        public DataTable carregaGrid()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(conexao);

            string strSql = "select id_usar,nome,sobrenome,celular from usuario";
           
            conn.Open();

            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //###################### CARREGAGRID PESQUISCA S/PARAMETRO ##############################

        public DataTable carregaGridPesquisa(string nome)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(conexao);

            string strSql = "select id_usar, nome, sobrenome, celular from usuario where nome like '%" + nome + "%' ";

            conn.Open();

            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        //fim da classe cadastro
    }
}
