using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Projecao
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public Cadastrar(String nome, String ddd, String telefone)
        {

            //comendo sql -- insert, update, delete --SqlCommand
            cmd.CommandText = "insert into cliente (nome) values (@nome)";
            cmd.CommandText = "insert into telefone (ddd) values (@ddd, @telefone)";


            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@ddd", ddd);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                //conectar com BD -- Conexao
                cmd.Connection = conexao.conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
                //desconectar BD
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso - variavel
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
            }
        }
    }
}
