using BacanasBurgues.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio
{
     public class RepositorioDeCliente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public void Salvar(Cliente cliente)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Cliente values(@identificador, @nome, @endereco,@telefone,@cep)";
            // parametros
            cmd.Parameters.AddWithValue("@identificador", cliente.Identificador);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@cep", cliente.Cep);
            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException e ) 
            {
                this.mensagem = e.Message;
            }
      
        }
    }
}
