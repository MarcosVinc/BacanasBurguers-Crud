using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BacanasBurgues.Entidades.Ultilitarios
{
    public class ConversorDeTipo
    {

        public static decimal ConvertaStringParaDecimal(string valor, int casasDouble)
        {
            return Math.Round(Convert.ToDecimal(valor.Replace(".", ","),
                                                    CultureInfo.CurrentCulture),
                                                    casasDouble)+ 0.00M;
        }
    }
}
