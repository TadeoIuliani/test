namespace CalculadoraEntidad
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            if(numeros == "")
            {
                return 0;
            }
            else
            {
                string[] num = numeros.Split(',');
                if(num.Length > 2)
                {
                    throw new ArgumentException();
                }
            
                else
                {
                    int total = 0;
                    foreach (var item in num)
                    {
                        total += int.Parse(item);
                    }
                    return total;
                }

            }

        }
    }
}
