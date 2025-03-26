using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

class Guerreiro : Personagem
{
    public string Arma { get; set; }

    public Guerreiro(string nome, int vida, int forca, int agilidade, string arma)
        : base(nome, vida, forca, agilidade)
    {
        Arma = arma;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} ataca com a arma {Arma} causando {Forca} de dano!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} levanta o escudo e reduz o dano!");
    }
}

}