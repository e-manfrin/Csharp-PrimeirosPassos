using System;

namespace P12_CalculaInvestimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 5; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Tempo de investimento terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
