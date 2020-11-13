using System;

namespace ejercicio_3_2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double terminos;
            double resultado = 0;
            double divisor = 1;

            Console.WriteLine(Math.PI);

            Console.Write("Nº de términos: ");
            terminos = Convert.ToDouble(Console.ReadLine());
            
            for (int i = 1; i <= terminos; i++)
            {
                if (i % 2 == 0)
                    resultado -= (1 / divisor);
                else
                    resultado += (1 / divisor);

                divisor += 2;
            }
            
            Console.WriteLine(resultado * 4);
        }
    }
}
