using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO_funcionario.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("informe o nome do primeiro funcionario: ");
            funcionario1.nome = Console.ReadLine();

            Console.WriteLine("imforme o salario do primeiro funcionario: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o nome do segundo funcionario: ");
            funcionario2.nome = Console.ReadLine();

            Console.WriteLine("imforme o salario do segundo funcionario: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            double media = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine($"a media dos dois funcionarios sera de " + media .ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
