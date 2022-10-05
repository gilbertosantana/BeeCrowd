using System;

namespace BeeCrowd1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parada = 0;
            int x;

            do
            {
                x = Int32.Parse(Console.ReadLine());
                
                if (x != parada)
                {
                    Console.WriteLine(SomaPares(x));
                }

            } while (x != parada);
        }

        public static int SomaPares(int valor)
        {
            int soma = 0;
            int total = 0;
            int parada = 5;

            while (total < parada)
            {
                if (valor % 2 == 0)
                {
                    soma += valor;
                    total++;
                }
                valor++;
            }

            return soma;
        }
    }
}
