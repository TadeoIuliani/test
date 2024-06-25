using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEntidad
{
    public  class Calculadora3
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
                List<string> num = numeros.Split(',').ToList();
                int total = 0;
                foreach (var item in num)
                {
                    if (int.TryParse(item, out int a))
                    {
                        total += a;
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
