Console.WriteLine("Calcular horas trabalhdas");

int entrada;
int saida;
int total;
int totalmeianoite;

Console.WriteLine("Inisira a hora de entrada no trabalho");
entrada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inisira a hora de saida no trabalho");
saida = Convert.ToInt32(Console.ReadLine());

total = entrada - saida;
totalmeianoite = (entrada - 24) + (24 - saida);

if (saida < entrada) 
{
    Console.WriteLine($"\nVocê trabalhou {totalmeianoite} Horas e passou da meia noite");
}
else
{
    Console.WriteLine($"\nVocê trabalhou {total} Horas e não passou da meia noite");
}