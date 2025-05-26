using System;
class Program
{
    static void Main()
    {
        int valor = 1;
        int tabuada = 0;

        Console.WriteLine($"Inisira o valor para calcular a tabuada:");
        tabuada = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{tabuada} * {valor} = {tabuada*valor}");
            valor++;
        }
    }
}
