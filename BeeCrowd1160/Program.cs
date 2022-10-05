using System;
using System.Globalization;

namespace BeeCrowd1160
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] values;
            int pA;
            int pB;
            double g1;
            double g2;
            int years = 0;

            if (t >= 1 & t <= 3000)
            {
                for (int i = 0; i < t; i++)
                {
                    values = Console.ReadLine().Split(' ');
                    pA = int.Parse(values[0]);
                    pB = int.Parse(values[1]);
                    g1 = double.Parse(values[2], CultureInfo.InvariantCulture);
                    g2 = double.Parse(values[3], CultureInfo.InvariantCulture);

                    while(pA <= pB)
                    {
                        pA += (int)((g1 * pA)/ 100);
                        pB += (int)((g2 * pB)/ 100);

                        years++;
                    }

                    if (years > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                    }
                    else
                    {
                        Console.WriteLine($"{years} anos.");
                    }
                    years = 0;
                }
            }
        }
    }
}
