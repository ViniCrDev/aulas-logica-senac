using System;

class Program
{
    static void Main()
    {
        
        int[,] matriz = new int[3, 3];
        int somaDiagonal = 0;

        
        Console.WriteLine("Preencha a matriz 3x3:");

        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write($"Digite o valor para matriz[{i}][{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());

                
                if (i == j)
                {
                    somaDiagonal += matriz[i, j];
                }
            }
        }

 
        Console.WriteLine("\nMatriz preenchida:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }

        
        Console.WriteLine($"\nA soma dos valores da diagonal principal é: {somaDiagonal}");
    }
}
