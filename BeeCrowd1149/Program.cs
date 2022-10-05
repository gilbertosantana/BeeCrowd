using System;

namespace BeeCrowd1149
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int N = int.Parse(valores[valores.Length-1]);
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += A + i;
            }
            Console.WriteLine(sum);
        }
    }
}
