using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um numero para saber se ele e par ou impar:");
            int numero = Convert.ToInt32(Console.ReadLine()!);

            if(numero % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }

        }
    }
}