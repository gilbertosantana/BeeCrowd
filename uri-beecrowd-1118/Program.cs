using System;
using System.Globalization;

namespace uri_beecrowd_1118
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int calculo = 1;
            while (calculo != 2)
            {
                if (calculo == 1)
                {
                    int notasValidas = 0;
                    double somaDeNotas = 0.0;
                    while (notasValidas != 2)
                    {
                        double nota = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("en-US"));

                        if(nota >= 0.0 && nota <= 10.0)
                        {
                            somaDeNotas += nota;
                            notasValidas++;
                        }
                        else
                        {
                            Console.WriteLine("nota invalida");
                        }
                    }
                    Console.WriteLine("media = " + (somaDeNotas/notasValidas).ToString("f2", CultureInfo.CreateSpecificCulture("en-US")));
                }
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                calculo = int.Parse(Console.ReadLine());
            }
        }
    }
}
