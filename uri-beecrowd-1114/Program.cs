using System;

namespace uri_beecrowd_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int entrada = int.Parse(Console.ReadLine());
            
            while (entrada != senha)
            {
                Console.WriteLine("Senha Invalida");

                entrada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
