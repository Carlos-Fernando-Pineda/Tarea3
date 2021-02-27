using System;

namespace P._146__Ejercicio_1
{
    class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Ingrese un numero para consultar su tabla: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "x" + i + "=" + (i * num));
            }
        }
    }
}
