using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanasBurgues.Entidades.Ultilitarios
{
    public class ConversorDeNumeros
    {
        public static decimal ConvertaStringParaDecimal(string valor, int casasDepoisDaVirgula)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return 0;
            }
            return Math.Round(Convert.ToDecimal(valor.Replace(".", ","),
               CultureInfo.CurrentCulture),
               casasDepoisDaVirgula) + 0.00M;

        }

        public static int ConvertaStringParaInt(string valor, int casasDepoisDaVirgula)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return 0;
            }
            return int.Parse(valor);

        }
    }
}
