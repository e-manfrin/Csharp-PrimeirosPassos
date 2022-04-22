using System;

namespace P10_CalculaPounpanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 1 mês,vc terá R$ " + valorInvestido);

            

            Console.ReadLine();
        }
    }
}
