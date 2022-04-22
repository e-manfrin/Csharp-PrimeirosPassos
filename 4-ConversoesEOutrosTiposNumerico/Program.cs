using System;

namespace _4_ConversoesEOutrosTiposNumerico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 Criando variáveis ponto flutuante");


            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            long idade;
            idade = 13000000000000;

            short quantidadeProdutos;
            quantidadeProdutos = 150;

            float altura = 1.80f;

            Console.WriteLine("Executando Finalizou.Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
