Console.WriteLine("Cálculo de salário com hora extra");

decimal salario = 0.00m;
int horas = 0;
decimal total = 0.00m;
decimal imposto = 0.10m;
decimal totalimposto = 0.00m;

Console.WriteLine("Inisira o valor do seu salário");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Inisira a quantidade de horas extras");
horas = Convert.ToInt32(Console.ReadLine());

total = (horas * 50) + salario;
totalimposto = total * imposto; 

if (total > 5000)
{
    Console.WriteLine($"\n Seu salário é de R${salario}, você fez {horas} horas extras e vai receber R${total} menos R${totalimposto} de imposto - Total R${total - totalimposto}");
}
else
{
    Console.WriteLine($"\n Seu salário é de R${salario}, você fez {horas} horas extras e vai receber R${total}");
}