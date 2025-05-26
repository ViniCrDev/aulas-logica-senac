using System;

class Program
{
    static void Main()
    {
        string[] senha = {"A01","A02","A03","A04","A05"};
        int i = 0;

        do 
        {
            Console.WriteLine($"Senha: {senha[i]}");
            i++;
        }
        while (i < senha.Length);
    }
}