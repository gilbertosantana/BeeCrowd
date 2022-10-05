using System;

namespace BeeCrowd1173
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];

            int number = int.Parse(Console.ReadLine());

            if (number <= 50)
            {
                values[0] = number;

                for (int i = 1; i < values.Length; i++)
                {
                    values[i] = values[i - 1] * 2;
                }
            }

            for (int j = 0; j < values.Length; j++)
            {
                Console.WriteLine($"N[{j}] = {values[j]}");
            }
        }
    }
}
