﻿using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(idade);

            idade = 5.0 / 3;
            Console.WriteLine(idade);

            Console.WriteLine("Executando Finalizou.Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
