using System;

namespace ejercicio_3_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3;

            Console.WriteLine("Introduce dos números de hasta 12 cifras decimales.");

            Console.Write("Número 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            numero3 = numero1 / numero2;

            Console.WriteLine("Resultado de la división con tres cifras decimales");
            Console.WriteLine("Con \"0.000\": {0}", numero3.ToString("0.000"));
            Console.WriteLine("Con \"N3\": {0}", numero3.ToString("N3"));
        }
    }
}
