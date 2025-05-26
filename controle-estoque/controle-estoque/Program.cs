using System;

class Program
{
    static void Main()
    {
        string[] produtos = new string[5];
        int[] quantidade = new int[5];
        int i = 0;

        do
        {
            Console.WriteLine($"Insira o nome do produto {i + 1}:");
            produtos[i] = Console.ReadLine();

            Console.WriteLine($"Inisira a quantidade do produto {produtos[i]} em estoque");
            while (!int.TryParse(Console.ReadLine(), out quantidade[i]))
            {
                Console.Write("Quanridade inválida. Insira quantidade em estoque: ");
            }

            i++;
        }
        while (i<5);

        Console.WriteLine("\nDados de Produtos:");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine($"Produto: {produtos[i]}, Quantidade: {quantidade[i]}");           
        }

        for (i = 0; i < 5; i++)
        {
            if (quantidade[i] < 5)
            {
                Console.WriteLine($"A quantida do produto {produtos[i]} é menor que 5");
            }
        }
    }
}