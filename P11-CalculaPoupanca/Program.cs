using System;

namespace P11_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês,vc terá R$ " + valorInvestido);
            }
            
            Console.ReadLine();
        }
    }
}
