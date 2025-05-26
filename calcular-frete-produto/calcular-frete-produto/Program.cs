using System;

class Program
{
    static void Main()
    {
        decimal valorProduto, distancia = 0.00m;

        Console.WriteLine("Escreva o valor do produto:");
        valorProduto = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"\nEscreva o valor da distancia:");
        distancia = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"\nValor total com frete R${frete(valorProduto, distancia):F2}");
    }

    static decimal frete(Decimal valor, Decimal km)
    {
        return valor + (km * 0.05m);   
    }
}