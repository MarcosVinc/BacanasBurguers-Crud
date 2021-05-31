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
        public void Alterar(TelefonesUteis alterartelefones)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "update TelefonesUteis set Nome = @nome, Telefone = @telefone where Identificador = @identificador";
            //parametros
            cmd.Parameters.AddWithValue("@identificador", alterartelefones.Identificador);
            cmd.Parameters.AddWithValue("@nome", alterartelefones.Nome);
            cmd.Parameters.AddWithValue("@telefone", alterartelefones.Telefone);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "alterada com sucasso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }

        public void Deletar(TelefonesUteis deletarTelefones)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "DELETE FROM TelefonesUteis WHERE Identificador = @identificador;"; ;
            //parametros
            cmd.Parameters.AddWithValue("@identificador", deletarTelefones.Identificador);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Excluida com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }

    }
}
