using System;

namespace P._146__Ejercicio_2
{
    class Program
    {
        static void Main()
        {
            double num, potencia, resultado;
            Console.WriteLine("Ingresar un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar una potencia para elevar el numero: ");
            potencia = int.Parse(Console.ReadLine());
            resultado = Math.Pow(num, potencia);
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
