using System;

namespace Uri1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, c, soma;

            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());


            while(z<=x)
            {
                z = int.Parse(Console.ReadLine());
            }

            c = 1;
            soma = x;

            do
            {

                x = x + 1;
                soma = soma + x;
                c = c + 1;

            } while (soma <= z);

            Console.WriteLine(soma);

        }
    }
}
