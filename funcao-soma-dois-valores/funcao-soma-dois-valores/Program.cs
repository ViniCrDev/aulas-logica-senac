using System;

class Program
{
    
    
    static void Main()
    {
        Console.WriteLine("Soma de dois numeros");
        
        int numero1, numero2 = 0;
        int soma = 0;   

        Console.WriteLine("Digite o primeiro numeros");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numeros");
        numero2 = Convert.ToInt32(Console.ReadLine());

        soma = somar(numero1, numero2);

        Console.WriteLine($"\n {numero1} + {numero2} = {soma}");
    } 

    
    static int somar(int n1, int n2)
    {
        return n1 + n2;
       
    }
}