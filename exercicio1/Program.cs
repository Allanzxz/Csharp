﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Possui autorização do responsável? (s/n): ");
        string autorizacao = Console.ReadLine().Trim().ToLower();

        if (idade >= 18 || autorizacao == "s")
        {
            Console.WriteLine("Entrada Liberada");
        }
        else
        {
            Console.WriteLine("Entrada não permitida");
        }



bool possuiPresencaMinima = true;
double media = 41.5;

if (!possuiPresencaMinima)
{
    Console.WriteLine("Reprovado");
}
else if(possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else 
{
    Console.WriteLine("Reprovado");
}