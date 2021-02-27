using System;

namespace P._110__Ejercicio_1
{
    class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Ingrese un numero para saber si es par o impar: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
