using System;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            idade = 5 + 10;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é: " + idade);

            Console.WriteLine("Executando projeto finalizado");
            Console.ReadLine();
            
        }
    }
}
