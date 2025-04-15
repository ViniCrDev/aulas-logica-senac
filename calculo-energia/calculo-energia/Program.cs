Console.WriteLine("Cálculo de energia com bandeira tarifária");

decimal kwh = 0.00m;
decimal verde = 0.50m;
decimal amarela = 0.75m;
decimal vermelha = 1.00m;
int bandeira = 0;

Console.WriteLine("Insira quantos kWh você consumiu");
kwh = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Inisira sua bandeira 0-Sair 1-Verde 2-Amarela 3-Vermelha");
bandeira = Convert.ToInt16(Console.ReadLine());

switch(bandeira)
{
    case 0:
        Console.WriteLine("Você finalizou o programa");
            break; 
    case 1: 
        Console.WriteLine($"\n Sua bandeira é verde, você utilizou {kwh}kWh e seu gasto foi de R${kwh * verde}");
        break;
    case 2:
        Console.WriteLine($"\n Sua bandeira é amarela, você utilizou {kwh}kWh e seu gasto foi de R${kwh * amarela}");
        break;
    case 3:
        Console.WriteLine($"\n Sua bandeira é vermelha, você utilizou {kwh}kWh e seu gasto foi de R${kwh * vermelha}");
        break;
    default:
        Console.WriteLine("Opção invalida");
        break;
}