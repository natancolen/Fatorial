using System;

namespace Fatorial
{
    class Program
    {
        /// <summary>
        /// Metodo Fatorial Iterativo
        /// </summary>
        /// <param name="n">Numero do fatorial</param>
        /// <returns></returns>
        static int FatorialIterativo(int n)
        {
            int r = n;

            if (n == 0) r++;

            while (n > 1)
            {
                Console.Write(r + " ");
                r *= --n;
            }
            return r;
        }

        /// <summary>
        /// Fatorial Recursivo
        /// </summary>
        /// <param name="n">Numero fatorial</param>
        /// <returns></returns>
        static int FatorialRecursivo(int n)
        {
            return n == 0 ? 1 : n * FatorialRecursivo(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n-Iterativo-");
            int valor = FatorialIterativo(n);

            Console.WriteLine("\n\n-Recursivo-");
            valor = FatorialRecursivo(n);
            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
