Console.WriteLine("Verificar se um número é múltiplo de 3 e/ou 5");

int numero = 0;

Console.WriteLine("Insira um número e descubra se é multiplo de 3 e 5");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 3 == 0 && numero % 5 == 0)
{
    Console.WriteLine($"\nO número {numero} é multiplo de três e cinco");
}
else
{
    Console.WriteLine($"\nO número {numero} não é multiplo de três e cinco");
}