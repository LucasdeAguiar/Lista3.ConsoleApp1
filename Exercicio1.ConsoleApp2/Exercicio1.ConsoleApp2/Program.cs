using System;

namespace Exercicio1.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            



            //Atribuição

            Console.WriteLine("Digite o valor que será atribuído na posição: 0" );
             numeros[0] = System.Convert.ToInt32(Console.ReadLine());


            int maior = numeros[0], menor= numeros[0];

            for (int i = 1; i <15; i++)
            {
                Console.WriteLine("Digite o valor que será atribuído na posição: " + i);
                 numeros[i] = System.Convert.ToInt32(Console.ReadLine());

                if (numeros[i]>maior)
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }




            //Resultado
            Console.Write("Lista dos números: ");
            for (int i = 0;i < 15; i++)
            {
              
                Console.Write(" " + numeros[i]);
                
                
            }
            Console.WriteLine("");
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número: " + maior);

        




        }
    }
}
