using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_calculadora.Modelo
{
    public class Calculadora
    {
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: Divisão por zero!");
            return double.NaN; // Retorna "Not a Number" se tentar dividir por zero
        }
        return a / b;
    }
}

}
