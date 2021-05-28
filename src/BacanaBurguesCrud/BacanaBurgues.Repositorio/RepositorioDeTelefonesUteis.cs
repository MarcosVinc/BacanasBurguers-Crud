using BacanasBurgues.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio
{
    public class RepositorioDeTelefonesUteis
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(TelefonesUteis _telefonesuteis) 
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into TelefonesUteis values(@identificador, @nome,@telefone)";
            //parametros
            cmd.Parameters.AddWithValue("@identificador", _telefonesuteis.Identificador);
            cmd.Parameters.AddWithValue("@nome", _telefonesuteis.Nome);
            cmd.Parameters.AddWithValue("@telefone", _telefonesuteis.Telefone);
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
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
        public List<TelefonesUteis> Consulta()
        {
            var telefonesuteis = new List<TelefonesUteis>();

            cmd.CommandText = "select * from TelefonesUteis";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    TelefonesUteis x = new TelefonesUteis();
                    x.Identificador = (string)read["Identificador"];
                    x.Nome = (string)read["Nome"];
                    x.Telefone = (string)read["Telefone"];
                    telefonesuteis.Add(x);
                }

                read.Close();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

            return telefonesuteis;

        }

    }
}
