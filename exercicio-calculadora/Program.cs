using System;
using exercicio_calculadora.Modelo;

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora(); // Criamos um objeto da classe Calculadora

        Console.WriteLine("Escolha uma operação: +, -, *, /");
        string operacao = Console.ReadLine(); // Lê a operação escolhida pelo usuário

        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // Lê o primeiro número

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // Lê o segundo número

        double resultado = 0;

        // **Verifica qual operação foi escolhida**
        switch (operacao)
        {
            case "+":
                resultado = calc.Somar(num1, num2);
                break;
            case "-":
                resultado = calc.Subtrair(num1, num2);
                break;
            case "*":
                resultado = calc.Multiplicar(num1, num2);
                break;
            case "/":
                resultado = calc.Dividir(num1, num2);
                break;
            default:
                Console.WriteLine("Operação inválida!");
                return; // Sai do programa se a operação não for válida
        }

        // **Exibe o resultado**
        Console.WriteLine($"Resultado: {resultado}");
    }
}
