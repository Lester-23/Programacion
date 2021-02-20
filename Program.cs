using System;

namespace AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ingrese el año que desea consultar: ");
            a = int.Parse(Console.ReadLine());

            if (a%4 != 0)
            {
                Console.WriteLine("\nEl año no es bisiesto");
            }
            else if(a%100 != 0)
            {
                Console.WriteLine("\nEl año es bisiesto");
            }

        }      

    }
}

