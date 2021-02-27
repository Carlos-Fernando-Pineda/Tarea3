using System;

namespace P._110__Ejercicio_4
{
    class Program
    {
        static void Main()
        {
            int op;
            do
            {
                Console.WriteLine("Ingresa un numero del 1 al 7 y te dire un dia de la semana, selecciona 8 para salir: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Domingo!");
                        break;
                    case 2:
                        Console.WriteLine("Lunes!");
                        break;
                    case 3:
                        Console.WriteLine("Martes!");
                        break;
                    case 4:
                        Console.WriteLine("Miercoles!");
                        break;
                    case 5:
                        Console.WriteLine("Jueves!");
                        break;
                    case 6:
                        Console.WriteLine("Viernes!");
                        break;
                    case 7:
                        Console.WriteLine("Sabado!");
                        break;
                    case 8:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        Console.WriteLine("Ingresa un numero valido");
                        break;
                }
            } while (op != 8);
        }
    }
}
