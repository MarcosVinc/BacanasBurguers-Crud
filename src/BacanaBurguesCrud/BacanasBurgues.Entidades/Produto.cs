using System;

namespace BacanasBurgues.Entidades
{
    public class Produto
    {
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Lucro { get; set; }

        //Nome: Nome do produto
        //Tipo: Em qual tipo esse produto se enquadra
        // Quantidade: Quantidade de produdo a ser adicionada
        // Preco: O preço do produto em si, sem o o adicional.
        // Lucro : E quantos porcentos  do valor o cliente quer adicionar ao produto.

        public Produto(double preco, string nome, string tipo, int quantidade)
        {
            Preco = preco;
            Nome = nome;
            Tipo = tipo;
            Quantidade = quantidade;
        }
        public Produto() 
        {
            Identificador = Guid.NewGuid().ToString();
        }
    }
}
