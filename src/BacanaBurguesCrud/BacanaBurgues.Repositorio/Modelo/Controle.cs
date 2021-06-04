using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanaBurgues.Repositorio.Modelo
{
   public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string logim, string senha)
        {
            LoginComandos logincomando = new LoginComandos();
            tem = logincomando.verificarLogin(logim, senha);
            if (!logincomando.mensagem.Equals(""))
            {
                this.mensagem = logincomando.mensagem;
            }
            return tem;
           
        }
    }
}
