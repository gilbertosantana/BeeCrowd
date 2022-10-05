using System;

namespace BeeCrowd1164
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantTestsCase = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 0; i < quantTestsCase; i++)
            {
                int value = int.Parse(Console.ReadLine());

                for( int j = 1; j < value; j++)
                {
                    if(value % j == 0)
                    {
                        sum += j;
                    }
                }

                if (value == sum)
                {
                    Console.WriteLine($"{value} eh perfeito");
                }
                else
                {
                    Console.WriteLine($"{value} nao eh perfeito");
                }
                sum = 0;
            }
        }
    }
}
