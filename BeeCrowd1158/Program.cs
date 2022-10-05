using System;
using System.IO;

namespace BeeCrowd1158
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int quantCasos = int.Parse(Console.ReadLine());
            string[] valores;
            int total = 0;

            for (int i = 0; i < quantCasos; i++)
            {
                valores = Console.ReadLine().Split(' ');
                total = SomaImpares(int.Parse(valores[0]), int.Parse(valores[1]));

                Console.WriteLine(total);
            }

        }
        public static int SomaImpares(int x, int y)
        {
            int fim = 0;
            int soma = 0;

            while (fim < y)
            {
                if (x % 2 != 0)
                {
                    soma += x;
                    fim++;
                }
                x++;
            }
            return soma;
        }
    }
}
