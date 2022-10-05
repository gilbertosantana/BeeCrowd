using System;
using System.Globalization;

namespace uri_beecrowd_1117
{
    class Program
    {
        static void Main(string[] args)
        {


            int count = 0;
            double sum = 0.0;

            do
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));
                if (nota >= 0 && nota <= 10)
                {
                    count += 1;
                    sum += nota;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            } while (count < 2);

            Console.WriteLine("media = "+ (sum / count).ToString("f2", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
