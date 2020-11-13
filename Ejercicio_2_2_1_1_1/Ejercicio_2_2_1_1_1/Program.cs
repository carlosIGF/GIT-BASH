using System;

namespace Ejercicio_2_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int cifras = 0;

            Console.Write("Número: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                n = n / 10;

                cifras = cifras + 1;
            }

            Console.WriteLine("{0} cifras", cifras);

        }
    }
}
