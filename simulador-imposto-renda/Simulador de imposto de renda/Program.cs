Console.WriteLine("Simulador de imposto de renda");

decimal salario = 0.00m;
decimal imposto1 = 0.075m;
decimal imposto2 = 0.15m;
decimal imposto3 = 0.225m;
decimal imposto4 = 0.275m;


Console.WriteLine("Insira o seu salaraio");
salario = Convert.ToDecimal(Console.ReadLine());

if (salario <= 1900)
{
    Console.WriteLine("Isento");
}
else if (salario >= 1900.01m)
{
    Console.WriteLine($"\n Seu salário é de R${salario} e o imposto sobre ele é de {salario*imposto1}");
}
else if (salario >= 2800.01m)
{
    Console.WriteLine($"\n Seu salário é de R${salario} e o imposto sobre ele é de R${salario * imposto2}");
}
else if (salario >= 3700.01m && salario <= 4600.00m)
{
    Console.WriteLine($"\n Seu salário é de R${salario} e o imposto sobre ele é de R${salario * imposto3}");
}
else
{
    Console.WriteLine($"\n Seu salário é de R${salario} e o imposto sobre ele é de R${salario * imposto4}");
}
