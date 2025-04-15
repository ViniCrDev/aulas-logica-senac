
Console.WriteLine("Informe sua idade para saber a sua categoria como atleta:");

int idade;

idade = Convert.ToInt32(Console.ReadLine());

if (idade > 12 && idade < 18)
{
    Console.WriteLine("Sua categoria é Juvenil");
} 
else if (idade > 17)
{
    Console.WriteLine("Sua categoria é Adulto");
}
else
{
    Console.WriteLine("Sua categoria é infantil");
}