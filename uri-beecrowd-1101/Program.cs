using System;

namespace uri_beecrowd_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string valores = Console.ReadLine();
            string[] vet = valores.Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                int count = 0;

                if(m > n)
                {
                    for(int i = n; i <= m; i++)
                    {
                        Console.Write(i + " ");
                        count += i;
                    }
                    Console.WriteLine("Sum=" + count);
                }
                else
                {
                    for (int i = m; i <= n; i++)
                    {
                        Console.Write(i + " ");
                        count += i;
                    }
                    Console.WriteLine("Sum=" + count);
                }
                valores = Console.ReadLine();
                vet = valores.Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }
        }
    }
}
