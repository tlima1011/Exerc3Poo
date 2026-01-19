using System;
using System.Globalization;

namespace Exerc3Poo
{
    internal class Aluno
    {
        public string nome; 
        public double nota1;
        public double nota2;
        public double nota3; 

        public double somar()
        {
            return nota1 + nota2 + nota3;  
        }

        public double calcularRestante()
        {
            return 60.00 - somar();
        }

        public override string ToString()
        {
            Console.WriteLine($"NOTA FINAL = {somar().ToString("F2", CultureInfo.InvariantCulture)}");
            return somar() >= 60.00 ? "APROVADO" : $"REPROVADO\nFALTARAM {calcularRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS";     
        }
    }
}
