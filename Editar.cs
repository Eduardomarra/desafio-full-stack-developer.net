using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Projecao
{
    class Editar
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public Editar(String nome, String ddd, String telefone)
        {


            cmd.CommandText = "update cliente set nome = @nome where nome = @nome";
            cmd.CommandText = "update telefone set ddd = @ddd where ddd = @ddd";
            cmd.CommandText = "update telefone set telefone = @telefone where telefone = @telefone";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@ddd", ddd);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
        
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();
       
                conexao.desconectar();
    
                this.mensagem = "Alterado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }

    }
}
