using System;

namespace _5_CaracteresTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 Carcteres e textos");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (Char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso " + 2021;
            string cursosProgramacao = @"- .NET
- JAVA
- JAVASCRIPT"; 
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Executando Finalizou.Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
