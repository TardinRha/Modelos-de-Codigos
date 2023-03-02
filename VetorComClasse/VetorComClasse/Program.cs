//Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos.
//Armazene os N produtos em um vetor.
//Em seguida, mostrar o preço médio dos produtos.


using System;
using System.Globalization;
using VetorComClasse;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // [] indica que é um vetor
            // new Product[n] o "n" é onde indica o tamanho do vetor. Poderia ser um numero certo ao invés de n.
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price }; //a classe está sendo instanciada aqui. não foi feito um contrutor próprio então está usando o construtor padrão.
            }
            
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price; //.Price é para acessar, nesse caso, o preço na posição "i" do vetor.
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
