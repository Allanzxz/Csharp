using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

class Arqueiro : Personagem
{
    public int Flechas { get; set; }

    public Arqueiro(string nome, int vida, int forca, int agilidade, int flechas)
        : base(nome, vida, forca, agilidade)
    {
        Flechas = flechas;
    }

    public override void Atacar()
    {
        if (Flechas > 0)
        {
            Console.WriteLine($"{Nome} dispara uma flecha causando {Forca} de dano!");
            Flechas--;
        }
        else
        {
            Console.WriteLine($"{Nome} está sem flechas!");
        }
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} se esquiva rapidamente!");
    }
}

}