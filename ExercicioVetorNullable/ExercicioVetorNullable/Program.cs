//A dona de um pensionato possui dez quartos para alugar para estudantes,
//sendo esses quartos identificados pelos números 0 a 9.
//Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
//Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando
//o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
//N estudantes. Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos
//ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
//um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.




using ExercicioVetorNullable;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] estudantes = new Estudantes[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quartosAlugados = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quartosAlugados; i++)
            {
                int aluguel = i + 1;
                Console.WriteLine($"Aluguel #{aluguel}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudantes(nome, email, quarto);
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine("Quartos ocupados:");
                    Console.WriteLine(estudantes[i]);
                }
            }


        }
    }
}