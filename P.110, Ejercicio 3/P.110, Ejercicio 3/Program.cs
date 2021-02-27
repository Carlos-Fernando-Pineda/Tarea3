using System;

namespace P._110__Ejercicio_3
{
    class Program
    {
        static void Main()
        {
            int op, cantidad;
            float total, precio, impuesto;
            Console.WriteLine("--¿Que quiere hacer?--");
            Console.WriteLine("1. Medicina");
            Console.WriteLine("2. Otros");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Ingrese la cantidad del producto: ");
                    cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio del producto: ");
                    precio = float.Parse(Console.ReadLine());
                    total = precio * cantidad;
                    Console.WriteLine("El total es de: " + total);
                    break;
                case 2:
                    Console.Write("Ingrese la cantidad del producto: ");
                    cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el precio del producto: ");
                    precio = float.Parse(Console.ReadLine());
                    total = precio * cantidad;
                    impuesto = (float)(total * 0.12);
                    total = total - impuesto;
                    Console.WriteLine("El total, aplicando impuesto del 12%, es de: " + total);
                    break;
                default:
                    Console.WriteLine("Ingrese un valor valido");
                    break;
            }
        }
    }
}
