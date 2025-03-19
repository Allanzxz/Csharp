using System;
namespace exercicio_jogo_de_batalha.Modelo;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Jogo de Batalha ===");

        // Criar personagens
        Personagem jogador1 = new Personagem("Guerreiro", 100, 20);
        Personagem jogador2 = new Personagem("Mago", 80, 25);

        // Exibir status inicial
        jogador1.ExibirStatus();
        jogador2.ExibirStatus();
        Console.WriteLine("\nA batalha começa!\n");

        // Loop de batalha (turnos)
        while (jogador1.EstaVivo() && jogador2.EstaVivo())
        {
            jogador1.Atacar(jogador2);
            if (!jogador2.EstaVivo()) break; // Se jogador2 morreu, fim do jogo

            jogador2.Atacar(jogador1);
        }

        // Exibir resultado
        Console.WriteLine("\n=== Fim da Batalha! ===");
        if (jogador1.EstaVivo())
            Console.WriteLine($"{jogador1.Nome} venceu!");
        else
            Console.WriteLine($"{jogador2.Nome} venceu!");
    }
}
