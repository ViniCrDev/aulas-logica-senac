using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Soma de 1 a 100");

        int valor = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"{valor} + 1 = {valor}");
            valor++;
        }
    }
}
