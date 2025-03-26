using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_personagens.Modelo
{

    abstract class Personagem
    {
        protected string nome;
        protected int vida;
        protected int ataque;
        protected int defesa;

        public Personagem(string nome, int vida, int ataque, int defesa)
        {
            this.nome = nome;
            this.vida = vida;
            this.ataque = ataque;
            this.defesa = defesa;
        }

        // Getters e Setters
        public string GetNome() { return nome; }
        public void SetNome(string nome) { this.nome = nome; }

        public int GetVida() { return vida; }
        public void SetVida(int vida) { this.vida = vida; }

        public int GetAtaque() { return ataque; }
        public void SetAtaque(int ataque) { this.ataque = ataque; }

        public int GetDefesa() { return defesa; }
        public void SetDefesa(int defesa) { this.defesa = defesa; }

         // Métodos abstratos (serão implementados nas classes derivadas)
        public abstract void HabilidadeEspecial();
        public abstract void AtaqueEspecial();

        // Método concreto
        public void MostrarStatus()
        {
            Console.WriteLine($"Nome: {nome}, Vida: {vida}, Ataque: {ataque}, Defesa: {defesa}");
        }
         public void TomarDano(int dano)
    {
        vida -= dano;
        if (vida < 0) vida = 0;
        Console.WriteLine($"{nome} tomou {dano} de dano. Vida restante: {vida}");
    }

        public void Curar(int quantidade)
    {
        vida += quantidade;
        Console.WriteLine($"{nome} foi curado em {quantidade} pontos. Vida atual: {vida}");
    }
    }

}

