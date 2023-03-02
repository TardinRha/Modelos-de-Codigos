using ConsoleApp1;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais = ");
            Console.WriteLine(ConversorDeMoeda.Conversor(cotacaoDolar, valorCompra).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
 