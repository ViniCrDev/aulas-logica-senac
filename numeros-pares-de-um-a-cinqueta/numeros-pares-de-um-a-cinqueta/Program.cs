using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Numeros pares de 1 a 50");

        int valor = 0;

        for (int i = 0; i < 50; i++)
        {
            valor++;
            if (valor % 2 == 0)
            {
                Console.WriteLine($"Par: {valor}");
                
            }
            
         
        }
    }
}
