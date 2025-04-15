Console.WriteLine("Insira um número inteiro para que possa verificar se é Par ou impar:");

int numero;
decimal resultado;

numero = Convert.ToInt32(Console.ReadLine());

resultado = numero % 2;

if (resultado == 0)
{
    Console.WriteLine($"\n O número {numero} é par");
}
else
{
    Console.WriteLine($"\n O número {numero} é impar");
}