// See https://aka.ms/new-console-template for more information
decimal valor;
decimal desconto1 = 0.05m;
decimal desconto2 = 0.10m;
decimal total = 0;

Console.WriteLine("Insira o valor da compra para receber o desconto");
valor = Convert.ToDecimal(Console.ReadLine());



if (valor > 500 && valor < 1000)
{
    total = valor * desconto1;
} 
else if (valor > 1000 || valor == 1000)
{
    total = valor * desconto2;
}

Console.WriteLine($"\nO valor da compra foi: R${valor} e o desconto foi de R${total} e o valor a pagar é R${valor-total} ");
