using System;
using System.Globalization;

namespace uri_beecrowd
{
    class Beecrowd_1098
    {
        public static void Main(string[] args)
        {
            
            for (double i = 0; i <= 2; i+=0.2)
            {
                for (double j = 1; j <= 3; j++)
                {
                    
                    if (i == 0 || i == 1 || i > 1.9)
                    {
                        Console.WriteLine("I=" + Math.Round(i) + " J=" + Math.Round(i + (j % 10)));
                    }
                    else
                    {
                        Console.Write("I="+ i.ToString("f1", CultureInfo.CreateSpecificCulture("en-US")));
                        Console.Write((" J=" + (i + (j % 10)).ToString("f1", CultureInfo.CreateSpecificCulture("en-US"))));
                        Console.WriteLine();
                    }
                    
                }
            }
        }
    }
}
