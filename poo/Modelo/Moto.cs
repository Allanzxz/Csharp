using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Modelo
{
    public class Moto: Veiculo
    {
        private bool partidaEletrica{get; set;}
        private bool protetorDeCarenagem{get; set;}

        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool partidaEletrica, bool protetorDeCarenagem) : base(marca, modelo, ano, velocidadeAtual)
        {
            this.partidaEletrica = partidaEletrica;
            this.protetorDeCarenagem = protetorDeCarenagem;
        }
        public bool GetPartidaEletrica()
        {
            return partidaEletrica;
        }
         public void SetPartidaEletrica(bool partidaEletrica)
        {
            this.partidaEletrica=partidaEletrica;
        }

        public bool GetProtetorDeCarenagem()
        {
            return protetorDeCarenagem;
        }
        public void SetProtetorDeCarenagem(bool protetorDeCarenagem)
        {
            this.protetorDeCarenagem=protetorDeCarenagem;
        }

        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
    }
}