using System;

class Program
{
    static void Main()
    {
        decimal[] vendas = new decimal[0];
        int i = 0;
        decimal soma = 0.00m;

        do
        {
            Console.WriteLine($"Inisira o valor da venda: ");
            while (!decimal.TryParse(Console.ReadLine(), out vendas[i]))
            {
                Console.Write("Valor inválido. Insira um valor valido: ");
            }

            i++;


        }
        while (vendas[i] != 0);
    }
}