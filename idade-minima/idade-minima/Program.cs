
class Program
{
    static void senacstore()
    {
        decimal valor = 0.00m;
        int itens = 0;
        decimal media = 0.00m;
        decimal vendas = 0.00m;

        do
        {
            Console.WriteLine("Ensira o valor da venda ou 0 para sair");
            valor = Convert.ToDecimal(Console.ReadLine());
            vendas = vendas + valor;
            itens++;
            media = vendas / itens;
            Console.WriteLine($"\nO valor atual das vendas é de {valor} e foram vendidos {itens} itens");
            Console.WriteLine($"A media do valor das venda é de {vendas}");
           
        }
        while (valor != 0);
    }

    static void Main()
    {
        senacstore();
    }
}
