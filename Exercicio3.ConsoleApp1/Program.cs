using System;
//Desenvolver um algoritmo que efetue a soma de todos os números
//ímpares que são múltiplos de três e que se encontram no conjunto dos
//números de 1 até 500.


namespace Exercicio3.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma=0;

           

            for (int i = 0; i < 499; i++)
            {

                if ((i % 2) == 1)
                {
                    soma = soma + i;
                }

            }
            Console.WriteLine("Soma dos valores ímpares entre 0 e 500 é: " + soma);
        }
    }
}
