using System;

namespace UriBeeCrowd1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int v1 = 1;
            int v2 = 0;
            int v3 = 0;

            for (int i = 0; i < N*2; i++)
            {
                v2 = (int)Math.Pow(v1, 2) + (i % 2);
                v3 = (int)Math.Pow(v1, 3) + (i % 2);
                Console.WriteLine($"{v1} {v2} {v3}");
                v1 += (i % 2);
            }
        }
    }
}
