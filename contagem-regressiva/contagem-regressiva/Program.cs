using System;
class Program
{
    static void Main()
    {
        Console.WriteLine($"\nContagem regressiva");

        int valor = 10;

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"Contando de 1 a 10: {valor}");
            valor--;
        }
    }
}
