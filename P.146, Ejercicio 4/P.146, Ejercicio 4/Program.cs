using System;

namespace P._146__Ejercicio_4
{
    class Program
    {
        static void Main()
        {
            bool EsPrimo = true;
            Console.WriteLine("Numeros primos: ");
            for (int i = 2; i <=1000; i++)
            {
                for(int j = 2; j <= 1000; j++)
                {
                    if (i!= j && i % j == 0)
                    {
                        EsPrimo = false;
                        break;
                    }
                }
                if (EsPrimo)
                {
                    Console.Write("\t" + i);
                }
                EsPrimo = true;
            }
        }
    }
}
