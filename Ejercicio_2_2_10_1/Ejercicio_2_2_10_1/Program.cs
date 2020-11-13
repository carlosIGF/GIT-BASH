using System;
using System.Runtime.Serialization.Formatters;

namespace Ejercicio_2_2_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, min;

            Console.Write("Número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            min = (n1 > n2 ? n2 : n1);

            for (int i = min; i >= 1; i--)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
