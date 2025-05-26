using System;

class Program
{
    static void Main()
    {
        string[] aluno = new string[5];
        decimal[] nota = new decimal[5];
        int i = 0;
        decimal soma = 0.00m;
        decimal media = 0.00m;
        do
        {
            Console.WriteLine($"Insira o nome do aluno {i + 1}:");
            aluno[i] = Console.ReadLine();

            Console.WriteLine($"Inisira a nota do aluno {aluno[i]}: ");
            while (!decimal.TryParse(Console.ReadLine(), out nota[i]))
            {
                Console.Write("Nota inválida. Insira uma nota valida: ");
            }

            i++;
        }
        while (i < 5);

        Console.WriteLine("\nNota dos alunos:");
        for (i = 0; i < nota.Length; i++)
        {
            Console.WriteLine($"Aluno: {aluno[i]}, Nota: {nota[i]}");
            soma += nota[i];
        }

        media = soma / nota.Length;
        Console.WriteLine($"A média dos alunos da turma é {media:F2}");
    }
}