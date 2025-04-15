// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira sua idade para saber se você pode votar:");

int idade;

idade = Convert.ToInt32(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("Você não pode votar");
}
else
{
    Console.WriteLine("Você pode votar");
}