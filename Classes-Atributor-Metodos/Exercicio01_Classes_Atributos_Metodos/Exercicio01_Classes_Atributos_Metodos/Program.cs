// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
// Usar uma classe como mostrado no projeto.

using Exercicio01_Classes_Atributos_Metodos;
using System.Globalization;
{
   Retangulo retangulo = new Retangulo();
    
    Console.WriteLine("Entre a largura e altura do retângulo: ");
    retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();
    Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
}
