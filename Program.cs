using System;

namespace ContaDeUmAteDez
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Faça um programa que leia um número (inteiro e maior que zero) e escreva a sequência de zero ao número digitado.
            
            int i, n;
            Console.WriteLine("Informe um numero inteiro maior que zero:");
            i = int.Parse(Console.ReadLine());

            for (n = 0; n <= i; n++)
            {
                Console.WriteLine("{0} ", n);
            }
        }
    }
}
