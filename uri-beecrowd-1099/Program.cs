using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_beecrowd
{
    class Beecrowd_1099
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x;
            int y;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string valores = Console.ReadLine();
                string[] vet = valores.Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (y > x)
                {
                    for (int j = x + 1; j < y; j++)
                    {
                        if (j % 2 == 1)
                        {
                            count += j;
                        }
                    }
                    Console.WriteLine(count);
                    count = 0;
                }
                else
                {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 == 1)
                        {
                            count += j;
                        }
                    }
                    Console.WriteLine(count);
                    count = 0;
                }

            }
            
        }
    }
}
