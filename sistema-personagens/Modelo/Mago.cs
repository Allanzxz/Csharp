using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{
class Mago : Personagem
{
    private int mana;

    public Mago(string nome) : base(nome, 80, 30, 5)
    {
        this.mana = 100;
    }

    // Getters e Setters primeiro
    public int GetMana() { return mana; }
    public void SetMana(int mana) { this.mana = mana; }

    // Implementação dos métodos abstratos
    public override void HabilidadeEspecial()
    {
        Console.WriteLine($"{nome} conjura um escudo mágico!");
    }

    public override void AtaqueEspecial()
    {
        Console.WriteLine($"{nome} lança uma bola de fogo poderosa!");
    }
}

}
