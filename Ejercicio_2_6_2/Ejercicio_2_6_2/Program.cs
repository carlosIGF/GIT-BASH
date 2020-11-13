using System;
using System.Diagnostics;

namespace Ejercicio_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroleido = 0;
            int numero = 0;
            
            

            Console.Write("Introduce un número: ");
            numeroleido = Convert.ToInt32(Console.ReadLine());

            numero = numeroleido;


            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();
            for (int i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                    numero = numero / i;

                    i = 1;
                }
            }

            cronometro.Stop();
            Console.WriteLine($"Tiempo: {cronometro.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");

            Console.WriteLine("-------");

            int divisor = 2;
            numero = numeroleido;

            cronometro = new Stopwatch();
            cronometro.Start();
            while (numero != 1)
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine(divisor);
                    numero = numero / divisor;
                }
                else
                    divisor++;
            }
            cronometro.Stop();
            Console.WriteLine($"Tiempo: {cronometro.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Alta precisión");
            else
                Console.WriteLine("Baja precisión");
        }
    }
}
