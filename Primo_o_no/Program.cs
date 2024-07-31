using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Ingrese un número:");
        number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("El número no es primo.");
        }
        else if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            Console.WriteLine("El número es primo.");
        }
        else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
        {
            Console.WriteLine("El número no es primo.");
        }
        else
        {
            Console.WriteLine("El número es primo.");
        }

    }
}
