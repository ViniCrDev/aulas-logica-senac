Console.WriteLine("Conceito de nota - A, B, C, D, E");

decimal nota = 0.00m;

Console.WriteLine("Inisira sua nota:");
nota = Convert.ToDecimal(Console.ReadLine());

if (nota > 8 && nota < 11)
{
    Console.WriteLine("Sua nota está no conceito A");
}
else if (nota >= 7)
{
    Console.WriteLine("Sua nota está no conceito B");
}
else if (nota >= 5)
{
    Console.WriteLine("Sua nota está no conceito C");
}
else if (nota >= 3)
{
    Console.WriteLine("Sua nota está no conceito D");
}
else if (nota >= 0)
{
    Console.WriteLine("Sua nota está no conceito E");
}
else
{
    Console.WriteLine("Nota invalida");
}

