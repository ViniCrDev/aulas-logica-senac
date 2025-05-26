using System.Net.Mail;

class Program
{
    static void login()
    {
        string logar = "";
        string senha = "senha123";
        int tentativa = 0;
        while(logar != senha)
        {
            tentativa++;
            Console.WriteLine("Insira a senha:");
            logar = Console.ReadLine();

            if (logar == senha)
            {
                Console.WriteLine("Logado");
                
            }
            else if (tentativa>2) 
            { 
                Console.WriteLine("Bloqueado");
                break;                
            }
            else
            {
                Console.WriteLine("Tente Novamente");
            }
        }
    }
    static void Main()
    {
        login();
    }
}