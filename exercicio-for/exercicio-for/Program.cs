using System;

class Program
{
    
    static void inicio()
{
        string senha = "";

        for (; senha != "1234";)
    {
        Console.WriteLine("Digite a senha:");
        senha = Console.ReadLine();

        if (senha != "1234")
        {
            Console.WriteLine("Senha incorreta");
        }
        else
        {
            Console.WriteLine("Senha correta");
        }
    }
}

static void Main()
    {
        inicio();
    }
}

