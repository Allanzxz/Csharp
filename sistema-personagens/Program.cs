using System;
using sistema_personagens.Modelo;

class Program
{
    static void Main()
    {
        Guerreiro guerreiro = new Guerreiro("Arthur", 100, 15, 8, "Espada Longa");
        Mago mago = new Mago("Merlin", 80, 10, 12, 50);
        Arqueiro arqueiro = new Arqueiro("Robin", 90, 12, 15, 5);

        guerreiro.ExibirStatus();
        guerreiro.Atacar();
        guerreiro.Defender();

        Console.WriteLine();

        mago.ExibirStatus();
        mago.Atacar();
        mago.Defender();

        Console.WriteLine();

        arqueiro.ExibirStatus();
        arqueiro.Atacar();
        arqueiro.Atacar();
        arqueiro.Defender();
    }
}
