using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

class Mago : Personagem
{
    public int Mana { get; set; }

    public Mago(string nome, int vida, int forca, int agilidade, int mana)
        : base(nome, vida, forca, agilidade)
    {
        Mana = mana;
    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nome} lança uma bola de fogo causando {Forca * 2} de dano!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} cria uma barreira mágica para se defender!");
    }
}

}