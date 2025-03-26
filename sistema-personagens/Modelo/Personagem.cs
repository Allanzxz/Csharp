using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

abstract class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Forca { get; set; }
    public int Agilidade { get; set; }

    public Personagem(string nome, int vida, int forca, int agilidade)
    {
        Nome = nome;
        Vida = vida;
        Forca = forca;
        Agilidade = agilidade;
    }

    public abstract void Atacar();
    public abstract void Defender();

    public void ExibirStatus()
    {
        Console.WriteLine($"Personagem: {Nome} | Vida: {Vida} | Força: {Forca} | Agilidade: {Agilidade}");
    }
}

}