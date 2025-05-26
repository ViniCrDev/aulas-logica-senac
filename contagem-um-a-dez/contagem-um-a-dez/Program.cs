class Program
{

    static void senhaLogin()
    {
        string senha = "";
        bool login = false;

        do
        {
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();

            if (senha == "senha123")
            {
                login = true;
                Console.WriteLine("Login aprovado");
            }
            else
            {
                Console.WriteLine("Login negado");
            }
        }
        while (login == false);
    }
    //static void soma()
    //{
    //    decimal numero, soma = 0.00m;
    //    do
    //    {
    //        Console.WriteLine("Digite um número (0 para sair)");
    //        numero = Convert.ToDecimal(Console.ReadLine());
    //        soma = soma + numero;
    //        Console.WriteLine($"\nsoma total: {soma}");
    //    }
    //    while (numero != 0);

        
    //}

    //static void contagem()
    //{
    //    int i = 10;
    //    do
    //    {

    //        Console.WriteLine($"\n {i}");
    //        i--;
    //    }
    //    while (i > 0);
    //}

    static void Main()
    {
        //contagem();
        //soma();
        senhaLogin();
    }

}
