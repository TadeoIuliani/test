using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEntidad
{
    public static class Calculadora4
    {
        public static int Add(string numeros)
        {
            if (numeros == "")
            {
                return 0;
            }
            else
            {
                numeros = numeros.Replace(" ", "");
                numeros = numeros.Replace("/ n", ",");
                numeros = numeros.Replace("/n", ",");
                string separador = ",";
                string patron = null;
                if(numeros.Substring(0, 1) == "//")
                {
                    patron = numeros.Substring(2);
                    //numeros = numeros.Remove(2);
                }
                numeros = numeros.Replace("//", "");
                if(patron is not null)
                {
                    numeros = numeros.Replace(patron, separador);
                }

                List<string> num = numeros.Split(separador).ToList();
                int total = 0;
                foreach (var item in num)
                {
                    if (int.TryParse(item, out int a) && item != "")
                    {
                        total += a;
                    }
                    else if(item == separador)
                    {
                        total += 0;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                return total;
            }

        }

    }
}
