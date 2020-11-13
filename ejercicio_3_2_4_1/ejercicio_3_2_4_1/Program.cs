using System;

namespace ejercicio_3_2_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            float raiz;

            Console.Write("Número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            raiz = (float)Math.Sqrt(numero);

            Console.WriteLine("La raíz de {0} es {1}.", numero, raiz);
        }
    }
}
