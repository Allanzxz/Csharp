using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{
class Guerreiro : Personagem
{
    private string arma;

    public Guerreiro(string nome) : base(nome, 120, 25, 15)
    {
        this.arma = "Espada";
    }

    // Getters e Setters primeiro
    public string GetArma() { return arma; }
    public void SetArma(string arma) { this.arma = arma; }

    // Implementação dos métodos abstratos
    public override void HabilidadeEspecial()
    {
        Console.WriteLine($"{nome} usa um golpe giratório com sua {arma}!");
    }

    public override void AtaqueEspecial()
    {
        Console.WriteLine($"{nome} desfere um ataque devastador!");
    }
}

}

