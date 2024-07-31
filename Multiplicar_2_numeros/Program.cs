using System;

namespace Multiplicar_2_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numero1, resultado;

            Console.WriteLine("Digite dos numeros para multiplicarlos");
            numero = int.Parse(Console.ReadLine());
            numero1 = int.Parse(Console.ReadLine());

            resultado = numero * numero1;

            Console.WriteLine("El resltado de la multipliación es " + resultado);




        }

    }

}