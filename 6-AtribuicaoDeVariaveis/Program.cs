using System;

namespace _6_AtribuicaoDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int ? teste = null;

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

           

            Console.WriteLine("Executando Finalizou.Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
