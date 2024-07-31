using System;

class Program
{
    static void Main(string[] args)
    {
        int[] secuenciaFibonacci = new int[] { 0, 1, 2, 3, 5, 8, 13, 21, 34 };
        foreach (int numero in secuenciaFibonacci)
        {
            Console.WriteLine(numero);
        }
        // En este caso solo esta hasta el 34 porque esta secuencia no llega al 50 como tal sino al 55 por lo tanto prefiero no ponerlo
    }
}
