using System;

namespace Ejercicio_2_2_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, max, mcm;

            Console.Write("Número 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            mcm = 0;
            max = (n1 < n2 ? n2 : n1);

            for (int i = max; i >= 1; i--)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    int mcd = i;

                    mcm = (n1 * n2) / mcd;

                    break;
                }
            }

            Console.WriteLine(mcm);
        }
    }
}
