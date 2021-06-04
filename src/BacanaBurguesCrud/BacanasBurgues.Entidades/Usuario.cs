using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanasBurgues.Entidades
{
    public class Usuario
    {
       public string Identificador { get; set; }
       public string Login { get; set; }
       public string Senha { get; set; }

        public Usuario(string login, string senha) 
        {
            Login = login;
            Senha = senha;
        }

        public Usuario()
        {
            Identificador = Guid.NewGuid().ToString();
        }
    }
}
