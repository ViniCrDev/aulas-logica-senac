using System;
class Program
{
    static void Main()
    {
        string[] nome = new string[5];
        int[] idade = new int[5];
        int i = 0;

        do
        {
            Console.WriteLine($"Insira seu nome {i+1}: ");
            nome[i] = Console.ReadLine() ;

            Console.WriteLine($"Insira a idade {nome[i]}:");
            while (!int.TryParse(Console.ReadLine(), out idade[i]))
            {
                Console.Write("Idade inválida. Insira um número: ");
            }

            i++;

        }
        while (i < 5);

        Console.WriteLine("\nAlunos:");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine($"Nome: {nome[i]}, Idade: {idade[i]}");
        }

    }
    }
