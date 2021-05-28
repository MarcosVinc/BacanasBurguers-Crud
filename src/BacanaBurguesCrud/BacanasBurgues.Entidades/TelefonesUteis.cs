using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanasBurgues.Entidades
{
    public class TelefonesUteis
    {
        public string Identificador { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public TelefonesUteis(string nome, string telefone)
        {
            Telefone = telefone;
            Nome = nome;
        }
        public TelefonesUteis()
        {
            Identificador = Guid.NewGuid().ToString();
        }
    }
}
