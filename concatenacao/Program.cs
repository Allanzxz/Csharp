// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design.Serialization;

string nome1 = "Allan";
string saudacao1 = "Olá" + nome1 + "! Bem-vindo.";
Console.WriteLine(saudacao1);

string nome2 = "Allan";
string saudacao2 = $"Olá, {nome2}! Bem-vindo.";
Console.WriteLine(saudacao2);

int numero = 5;
Console.WriteLine(numero.GetType());

Console.WriteLine(typeof(int));

string valorTexto = "100";
Console.WriteLine("A variável valortexto é do tipo:" + valorTexto.GetType());

int numero3 = int.Parse(valorTexto);
Console.WriteLine(numero3);
Console.WriteLine("A variável numeroPerse é do tipo:" + numero3.GetType());

string valorEmTexto ="100";
Console.WriteLine("A variável valorTexto é do tipo:"+ valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variável numeroConvertido é do tipo:" + numeroConvertido.GetType());