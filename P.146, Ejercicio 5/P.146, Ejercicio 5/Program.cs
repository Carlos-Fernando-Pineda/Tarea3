using System;

namespace P._146__Ejercicio_5
{
    class Program
    {
        static void Main()
        {
            int per1, per2, per3;
            Console.Write("Introduzca la edad de la primera persona: ");
            per1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la edad de la segunda persona: ");
            per2 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la edad de la tercera persona: ");
            per3 = int.Parse(Console.ReadLine());

            if (per1 > per2 && per1 > per3)
            {
                Console.WriteLine("La mayor edad es " + per1);
            }
            else if (per2 > per1 && per2 > per3)
            {
                Console.WriteLine("La mayor edad es " + per2);
            }
            else if (per3>per1 && per3 > per2)
            {
                Console.WriteLine("La mayor edad es " + per3);
            }
            if (per1<per2 && per1 < per3)
            {
                Console.WriteLine("La menor edad es " + per1);
            }
            else if(per2<per1 && per2 < per3)
            {
                Console.WriteLine("La menor edad es " + per2);
            }
            else if(per3<per1 && per3 < per1)
            {
                Console.WriteLine("La menor edad es " + per3);
            }
        }
    }
}
