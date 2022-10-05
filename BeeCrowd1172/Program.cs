using System;

namespace BeeCrowd1172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value <= 0)
                {
                    numbers[i] = 1;
                }
                else
                {
                    numbers[i] = value;
                }
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"X[{j}] = {numbers[j]}");
            }
        }
    }
}
