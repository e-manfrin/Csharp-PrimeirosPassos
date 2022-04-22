using System;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }

            Console.ReadLine();



            /*Console.WriteLine("Projeto 7 - Condicionais");
            int idadeJoao = 17;
            int qtdPessoas = 0;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("Maior de idade pode entrar");
            }
            else if (idadeJoao <= 16)
            {
                Console.WriteLine("Menor de 16 anos não é permitido a entrada");
            }
            else if (qtdPessoas >= 2)
            {
                Console.WriteLine("Menor de idade porém acompanhado com responsável pode entrar");
            }
            else
            {
                Console.WriteLine("Menor de idade desacompanhado não pode entrar");
            }
            Console.ReadLine();*/
        }
    }
}
