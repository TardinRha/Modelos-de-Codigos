using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02_Classes_Atributos_Metodos
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentoSalario(double pocentagemAumento)
        {
            return (SalarioBruto * pocentagemAumento) + SalarioBruto;
        }
        
        public override string ToString()
        {
            return "Funcionário: " + Nome
                + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
