using System;

namespace ejercicio_3_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.Write("Escribe una letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            for (char c = letra; c <= 'z'; c++, c++)
            {
                Console.Write(c);
            }
        }
    }
}
