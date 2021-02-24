using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Projecao
{
    class Excluir
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public Excluir(String nome, String ddd, String telefone)
        {

            cmd.CommandText = "delete from cliente where @nome";
            cmd.CommandText = "delete from telefone where @ddd";
            cmd.CommandText = "delete from telefone where @telefone";

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
