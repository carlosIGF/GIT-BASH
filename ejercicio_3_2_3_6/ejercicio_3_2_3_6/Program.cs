using System;

namespace ejercicio_3_2_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            for (int i = 0; i <= 10; i++)
            {
                a = Math.Pow(i - 5, 2);

                for (int h = 0; h <= a; h++)
                {
                    if (h == a)
                        Console.WriteLine("*");
                    else
                        Console.Write(" ");
                }
            }
        }
    }
}
