using System;

namespace BeeCrowd1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(FatorialRecursao(n));
        }
        public static double FatorialRecursao(int numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * FatorialRecursao(numero - 1);
        }
    }
}
