using System;
using System.Collections.Generic;
using System.Globalization;

namespace BeeCrowd1174
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[100];
            List<int> positions = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if(number <= 10)
                {
                    positions.Add(i);
                }
                values[i] = number;
            }

            for (int j = 0; j < positions.Count; j++)
            {
                Console.WriteLine($"A[{positions[j]}] = {values[positions[j]].ToString("F1", CultureInfo.InvariantCulture)}"); 
            }
        }
    }
}
