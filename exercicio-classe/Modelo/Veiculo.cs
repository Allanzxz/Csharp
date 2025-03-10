using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercico_classe.Modelo
{
    public class Veiculo
    {
         //Atributos
       string marca;
       string modelo;
       int ano;
      

       //Construtor
       public Veiculo(string marca, string modelo, int ano)
       {
           this.marca = marca;
           this.modelo = modelo;
           this.ano = ano;
       }
        //Métodos Andar e Falar
        public void Acelerar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} está acelerando.");
        }
        public void Freiar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} freiou rapidamente.");
        }
    }
    }
