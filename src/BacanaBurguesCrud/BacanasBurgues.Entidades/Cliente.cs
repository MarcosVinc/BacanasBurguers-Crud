using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanasBurgues.Entidades
{
   public class Cliente
    {
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Cep { get; set; }

        public Cliente(string nome, string endereco, string telefone, int cep)
        { 
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cep = cep;
       }
        public Cliente() 
        {
            Identificador = Guid.NewGuid().ToString();


        }

    }
}
