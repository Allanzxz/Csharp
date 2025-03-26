using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

class Arqueiro : Personagem
{
    private int flechas;

    public Arqueiro(string nome) : base(nome, 90, 20, 10)
    {
        this.flechas = 30;
    }

    // Getters e Setters primeiro
    public int GetFlechas() { return flechas; }
    public void SetFlechas(int flechas) { this.flechas = flechas; }

    // Implementação dos métodos abstratos
    public override void HabilidadeEspecial()
    {
        Console.WriteLine($"{nome} dispara uma chuva de flechas!");
    }

    public override void AtaqueEspecial()
    {
        Console.WriteLine($"{nome} dispara uma flecha perfurante!");
    }
}

}

