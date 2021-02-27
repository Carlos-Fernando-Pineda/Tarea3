using System;

namespace P._110__Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            int op;
            do
            {
                double num, resultado;
                Console.WriteLine("--Que quiere hacer?--");
                Console.WriteLine("1. Grados a Radianes");
                Console.WriteLine("2. Radianes a Grados");
                Console.WriteLine("3. Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad que quiere convertir: ");
                        num = float.Parse(Console.ReadLine());
                        resultado = num * 3.1416 / 180;
                        Console.WriteLine("Su resultado es: " + resultado);
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad que quiere convertir: ");
                        num = float.Parse(Console.ReadLine());
                        resultado = num * 180 / 3.1416;
                        Console.WriteLine("Su resultado es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;

                }
            } while (op != 3);
        }
    }
}
