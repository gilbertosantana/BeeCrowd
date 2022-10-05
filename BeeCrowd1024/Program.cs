using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace BeeCrowd1024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCases = int.Parse(Console.ReadLine());
            string texto;

            for (int i = 0; i < numberCases; i++)
            {
                texto = Passada3(Passada2(Passada1(Console.ReadLine())));

                Console.WriteLine(texto);
            }
        }

        public static string Passada1(string texto)
        {
            string palavra = null;
            for (int j = 0; j < texto.Length; j++)
            {
                if(((int)texto[j] > 64 && (int)texto[j] < 91) || ((int)texto[j] > 96 && (int)texto[j] < 123))
                {
                    palavra += char.ConvertFromUtf32((int)texto[j] + 3);
                }
                else
                {
                    palavra += texto[j];
                }
            }
            return palavra;
        }

        public static string Passada2(string texto)
        {
            string palavra = null;

            for (int i = texto.Length-1; i >= 0; i--)
            {
                palavra += texto[i];
            }

            return palavra;
        }
        public static string Passada3(string texto)
        {
            string palavra = texto.Substring(0, (texto.Length/2));

            for (int i = texto.Length/2; i < texto.Length; i++)
            {
                palavra += char.ConvertFromUtf32(((int)texto[i] - 1));
            }

            return palavra;
        }
    }
}
