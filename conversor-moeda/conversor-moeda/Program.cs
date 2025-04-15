Console.WriteLine("Insira o valor em R$ e escolha uma opção para o valor ser convertido");

decimal reais = 0.00m;
decimal dolar = 5.00m;
decimal euro = 6.00m;
decimal pesoarg = 0.02m;
int converter;


Console.WriteLine("Insira o valor em reais para ser convertido:");
reais = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Escolha operação: 0=Sair 1=Dolar 2=Euro 3=Peso Argentino");
converter = Convert.ToInt32(Console.ReadLine());

switch (converter)
{
    case 0:
        Console.WriteLine("Você finalizou o programa");
        break;
    case 1:
        Console.WriteLine($"\nO valor de R${reais} em Dolar é {reais / dolar}");
        break;
    case 2:
        Console.WriteLine($"\nO valor de R${reais} em Euro é {reais / euro}");
        break;
    case 3:
        Console.WriteLine($"\nO valor de R${reais} em Pesos Argentinos é {reais / pesoarg}");
        break;
    default:
        Console.WriteLine("Opção inválida! Tente novamente.");
        break;
}