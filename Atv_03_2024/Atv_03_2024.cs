﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o operador aritmético desejado (+, -, *, /): ");
        char operador = Console.ReadLine()[0]; // Obtém o primeiro caractere digitado pelo usuário

        Console.WriteLine($"Tabuada do operador {operador}:");

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                int resultado = 0;

                switch (operador)
                {
                    case '+':
                        resultado = i + j;
                        break;
                    case '-':
                        resultado = i - j;
                        break;
                    case '*':
                        resultado = i * j;
                        break;
                    case '/':
                        if (j != 0) // Evita divisão por zero
                            resultado = i / j;
                        break;
                    default:
                        Console.WriteLine("Operador inválido.");
                        return;
                }

                Console.Write($"{i} {operador} {j} = {resultado,-3}\t");
            }
            Console.WriteLine();
        }
    }
}