using System;
using System.Globalization; 

namespace Exerc3Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine($"Digite as três notas do aluno(a): {a.nome}");
            a.nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine(a);
        }
    }
}
