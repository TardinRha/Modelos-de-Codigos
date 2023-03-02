using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConversorDeMoeda
    {
        public static double Conversor(double cotacaoDolar, double valorComprar)
        {
            return (valorComprar * cotacaoDolar) + ((valorComprar * cotacaoDolar) * 0.06);
        }
    }
}
