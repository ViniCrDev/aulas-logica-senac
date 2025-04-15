Console.WriteLine("Verificar se o usuário está correto");

string nome;
string senha;
string loginNome = "admin";
string loginSenha = "1234";

Console.WriteLine("Inisira o nome de usuário");
nome = Convert.ToString(Console.ReadLine());
Console.WriteLine("Inisira a senha");
senha = Convert.ToString(Console.ReadLine());

Console.Clear();

if (nome == loginNome && senha == loginSenha)
{
    Console.WriteLine("Acesso Liberado");
}
else if (nome == loginNome && senha != loginSenha)
{
    Console.WriteLine("Acesso negado, senha está incorreta");
}
else if (nome != loginNome && senha == loginSenha)
{
    Console.WriteLine("Acesso negado, nome de usuário incorreto");
}
else
{
    Console.WriteLine("Acesso Negado");
}