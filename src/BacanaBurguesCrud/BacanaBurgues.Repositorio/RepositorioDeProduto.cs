﻿using BacanasBurgues.Entidades;
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
                    x.Preco = double.Parse(read["Preco"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
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

    }
}
