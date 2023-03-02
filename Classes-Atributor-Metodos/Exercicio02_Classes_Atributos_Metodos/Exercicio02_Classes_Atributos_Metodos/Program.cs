// Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
// Em seguida, mostrar ps dados do funcionário (nome e salári líquido).
// Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruno é afetado
// pela porcentagem) e mostrar novamente os dados do funcionário.

using Exercicio02_Classes_Atributos_Metodos;
using System.Globalization;

{
    Funcionario funcionario1 = new Funcionario();

    Console.Write("Nome: ");
    funcionario1.Nome = Console.ReadLine();
    Console.Write("Salário Bruto: ");
    funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Imposto: ");
    funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    Console.WriteLine(funcionario1);

    Console.WriteLine();
    Console.Write("Digite a porcentagem para aumentar o salário: ");
    double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) / 100.0;
    Console.WriteLine();
    Console.Write("Dados Atualizados: " + funcionario1.Nome + ", $ " + (funcionario1.AumentoSalario(porcentagemAumento)-funcionario1.Imposto).ToString("F2", CultureInfo.InvariantCulture));

}