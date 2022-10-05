using System;

namespace uri_beecrowd_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(valores[0]);
            int valor2 = int.Parse(valores[1]);

            int count = 1;

            for (int i = 1; i <= valor2; i++)
            {
                if (count == valor1)
                {
                    Console.WriteLine(i);
                    count = 1;
                }
                else
                {
                    Console.Write(i + " ");
                    count += 1;
                }
            }

        }
    }
}
