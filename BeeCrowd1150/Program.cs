using System;

namespace BeeCrowd1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int sum = 0;
            int aux = 0;
            
            while (x >= z)
            {
                z = int.Parse(Console.ReadLine());
            }

            for (int i = x; i <= z; i++)
            {
                if(sum <= z)
                {
                    sum += i;
                    aux += 1;
                }
            }

            Console.WriteLine(aux);
        }
    }
}
