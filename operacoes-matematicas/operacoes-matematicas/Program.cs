Console.WriteLine("Caulculadora, insira dois numeros e escolha a operação");

decimal num1;
decimal num2;
int calculo;

calculo = 0;    

Console.WriteLine("Inisira o primeiro número");
num1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Inisira o segundo número");
num2 = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

Console.WriteLine("Escolha operação: 0-Sair 1=Soma 2=Subtração 3=Multiplicação 4=Divisão");
calculo = Convert.ToInt32(Console.ReadLine());


switch (calculo)
{
    case 0:
        Console.WriteLine("Operação finalizada");
        break;

    case 1:
        Console.WriteLine($"Resultado da soma {num1} e {num2}: {num1 + num2}");
        break;

    case 2:
        Console.WriteLine($"Resultado da subtração {num1} e {num2}: {num1 - num2}");
        break;

    case 3:
        Console.WriteLine($"Resultado da multiplicação {num1} e {num2}: {num1 * num2}");
        break;

    case 4:
        if (num2 != 0) 
        {
            Console.WriteLine($"Resultado da divisão {num1} e {num2}: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        break;

    default:
        Console.WriteLine("Opção inválida! Tente novamente.");
        break;
}