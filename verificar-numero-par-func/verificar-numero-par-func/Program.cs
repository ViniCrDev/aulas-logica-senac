using System;

class Program
{
    static void Main()
    {
        int numero = 0;
        Console.WriteLine("Verificar numero par");

        numero = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"O número é {numero} par? {parouimpar(numero)}");
    }

    static string parouimpar(int n)
    {
        return n % 2 == 0 ? "Par" : "Impar";
    }

}