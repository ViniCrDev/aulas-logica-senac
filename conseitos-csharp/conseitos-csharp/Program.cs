//Tipos numericos
using System.Net.Http.Headers;

byte b = 10;
int idade = 25;
long populacao = 7000000000000;

//Tipos Reais
float peso = 60.2f;
double altura = 1.75;
decimal salario = 2500.00m;

//Logicos e texto
bool aprovado = true;
char inicial  = 'V';
string nome = "Vinicius";

//inferência com var
var cidade = "São Paulo";
var nota = 2.5;
var letra = 'A';
var boleana = true;

Console.WriteLine("Nome: + nome");
Console.WriteLine($"Nome: \n {idade}");

//Calculo de media

double media, n1, n2;

Console.WriteLine("Digite dois valores para calcular a média");

Console.WriteLine("\nDigite o primeiro valor:");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nDigite o segundo valor:");
n2 = Convert.ToDouble(Console.ReadLine());

media = (n1 + n2)/2;

Console.WriteLine($"\nA media dos valores {n1} + {n2} é {media}");
