using System;

class Program
{
    static void Main()
    {
        int idade = 0;  
        Console.WriteLine("Informe sua idade");
        idade = Convert.ToInt32(Console.ReadLine());  
        
        Console.WriteLine($"\n{pordeMatricular(idade)}");
    }

    static string pordeMatricular(int idadeUsuario)
    {
        return idadeUsuario >= 16 ? "Pode matricular" : "Não pode matricular";
    }
}