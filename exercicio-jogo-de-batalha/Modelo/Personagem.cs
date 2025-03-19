using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_jogo_de_batalha.Modelo
{
    public class Personagem
    {
        public string Nome { get; private set; }
    public int HP { get; private set; }
    public int Ataque { get; private set; }

    public Personagem(string nome, int hp, int ataque)
    {
        Nome = nome;
        HP = hp;
        Ataque = ataque;
    }

    public void Atacar(Personagem alvo)
    {
        if (HP <= 0)
        {
            Console.WriteLine($"{Nome} não pode atacar, pois já foi derrotado!");
            return;
        }

        alvo.HP -= Ataque;
        if (alvo.HP < 0) alvo.HP = 0;

        Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {Ataque} de dano!");
        Console.WriteLine($"{alvo.Nome} agora tem {alvo.HP} HP restante.\n");
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"{Nome} - HP: {HP}");
    }

    public bool EstaVivo()
    {
        return HP > 0;
    }
    }
}