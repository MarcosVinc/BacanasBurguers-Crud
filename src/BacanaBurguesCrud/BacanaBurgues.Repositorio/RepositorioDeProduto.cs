using BacanasBurgues.Entidades;
using BacanasBurgues.Entidades.Ultilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio
{
    public class RepositorioDeProduto
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(Produto produto)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Produtos values(@identificador, @nome,@tipo, @preco,@lucro, @quantidade)";
            //parametros
            cmd.Parameters.AddWithValue("@identificador", produto.Identificador);
            cmd.Parameters.AddWithValue("@nome", produto.Nome);
            cmd.Parameters.AddWithValue("@tipo", produto.Tipo);
            cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            cmd.Parameters.AddWithValue("@preco", produto.Preco);
            cmd.Parameters.AddWithValue("@lucro", produto.Lucro);

   

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



        public List<Produto> Consulta()
        {
            var produto = new List<Produto>();

            cmd.CommandText = "select * from Produtos";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    Produto x = new Produto();
                    x.Identificador = (string)read["Identificador"];
                    x.Nome = (string)read["Nome"];
                    x.Tipo = (string)read["Tipo"];
                    x.Preco = ConversorDeNumeros.ConvertaStringParaDecimal(read["Preco"].ToString(), 2);
                    x.Lucro = int.Parse(read["lucro"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    x.Quantidade = int.Parse(read["Quantidade"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    produto.Add(x);
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

            return produto;

        }

        public void Deletar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Produto alterarProduto)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "update Produtos set Nome = @nome, Tipo = @tipo, Preco = @preco , lucro = @lucro, Quantidade = @quantidade where Identificador = @identificador";
            //parametros
            cmd.Parameters.AddWithValue("@identificador", alterarProduto.Identificador);
            cmd.Parameters.AddWithValue("@nome", alterarProduto.Nome);
            cmd.Parameters.AddWithValue("@tipo", alterarProduto.Tipo);
            cmd.Parameters.AddWithValue("@quantidade", alterarProduto.Quantidade);
            cmd.Parameters.AddWithValue("@preco", alterarProduto.Preco);
            cmd.Parameters.AddWithValue("@lucro", alterarProduto.Lucro);

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

        public void Deletar(Produto deletarProduto)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "DELETE FROM Produtos WHERE Identificador = @identificador;"; ;
            //parametros
            cmd.Parameters.AddWithValue("@identificador", deletarProduto.Identificador);

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


/*cmd.CommandText = "DELETE FROM Produtos WHERE Identificador = @identificador;";
cmd.Parameters.AddWithValue("@identificador", deletarProduto.Identificador);*/