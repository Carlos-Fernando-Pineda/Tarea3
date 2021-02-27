using System;

namespace P._110__Ejercicio_5
{
    class Program
    {
        static void Main()
        {
            int op;
            do
            {
                int lados;
                float apotema, lado, perimetro, area;
                Console.WriteLine("--¿Que quiere hacer?--");
                Console.WriteLine("--Area y perimetro de un poligono regular--");
                Console.WriteLine("1. Area");
                Console.WriteLine("2. Perimetro");
                Console.WriteLine("3. Salir");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el perimetro de el poligono: ");
                        perimetro = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el apotema de el poligono: ");
                        apotema = float.Parse(Console.ReadLine());
                        area = (perimetro * apotema) / 2;
                        Console.WriteLine("El area es de " + area);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la longitud del lado: ");
                        lado = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de lados: ");
                        lados = int.Parse(Console.ReadLine());
                        perimetro = lado * lados;
                        Console.WriteLine("El perimetro es de " + perimetro);
                        break;
                    case 3:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Escoger una opcion valida");
                        break;
                }
            } while (op != 3);
        }
    }
}
