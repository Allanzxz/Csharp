using System;
using sistema_personagens.Modelo;

class Program
{
    static void Main()
    {
        // Criando instâncias dos personagens
        Guerreiro guerreiro = new Guerreiro("Arthur");
        Mago mago = new Mago("Merlin");
        Arqueiro arqueiro = new Arqueiro("Legolas");

        // Testando os métodos herdados (concretos)
        Console.WriteLine("---- STATUS INICIAL ----");
        guerreiro.MostrarStatus();
        mago.MostrarStatus();
        arqueiro.MostrarStatus();
        Console.WriteLine();

        // Testando habilidades especiais
        Console.WriteLine("---- HABILIDADES ESPECIAIS ----");
        guerreiro.HabilidadeEspecial();
        mago.HabilidadeEspecial();
        arqueiro.HabilidadeEspecial();
        Console.WriteLine();

        // Testando ataques especiais
        Console.WriteLine("---- ATAQUES ESPECIAIS ----");
        guerreiro.AtaqueEspecial();
        mago.AtaqueEspecial();
        arqueiro.AtaqueEspecial();
        Console.WriteLine();

        // Testando métodos concretos herdados
        Console.WriteLine("---- COMBATE ----");
        guerreiro.TomarDano(20);
        mago.TomarDano(40);
        arqueiro.TomarDano(30);
        Console.WriteLine();

        Console.WriteLine("---- CURANDO PERSONAGENS ----");
        guerreiro.Curar(15);
        mago.Curar(20);
        arqueiro.Curar(10);
        Console.WriteLine();

        // Mostrando status final
        Console.WriteLine("---- STATUS FINAL ----");
        guerreiro.MostrarStatus();
        mago.MostrarStatus();
        arqueiro.MostrarStatus();
    }
}

