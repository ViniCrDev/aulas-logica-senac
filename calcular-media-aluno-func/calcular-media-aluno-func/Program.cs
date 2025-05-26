using System;

class Program
{
    static void Main()
    {
        decimal nota1, nota2 = 0.00m;
       
        Console.WriteLine("Calculo de midia");
        Console.WriteLine($"\nInsira primeira nota:");
        nota1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\nInsira segunda nota:");
        nota2 = Convert.ToDecimal(Console.ReadLine());

        if (media(nota1, nota2) >= 6)
        {
            Console.WriteLine($"\nMedia do aluno é {media(nota1, nota2):F2} e o aluno está aprovado");
        }
        else 
        {
            Console.WriteLine($"\nMedia do aluno é {media(nota1, nota2):F2} e o aluno está reprovado");
        }

    }

    static decimal media(decimal n1, decimal n2)
    {
       return (n1 + n2) / 2;
    }

}