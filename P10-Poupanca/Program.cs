using System;

namespace P10_Poupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês,vc terá R$ " + valorInvestido);
    
                contadorMes++;
            }
            Console.ReadLine();
        }
    }
}
