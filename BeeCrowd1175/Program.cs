using System;

namespace BeeCrowd1175
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[20];

            for (int i = values.Length-1; i >= 0; i--)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < values.Length; j++)
            {
                Console.WriteLine($"N[{j}] = {values[j]}");
            }
        }
    }
}
