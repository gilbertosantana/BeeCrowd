using System;
using System.Globalization;

namespace uri_beecrowd_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double v1 = double.Parse(vet[0]);
                double v2 = double.Parse(vet[1]);

                if (v2 == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((v1 / v2).ToString("f1", CultureInfo.CreateSpecificCulture("en-US")));
                }

            }
        }
    }
}
