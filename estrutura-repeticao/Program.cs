// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Número Alvo:{numero}");
while (contador <= numero)
{
    Console.WriteLine($"Contador:{contador}.");
    contador++;
}
Console.WriteLine($"Contador atingiu o número alvo:{contador}");


int numero1 = 0;

do{
    Console.WriteLine($"Número:{numero1}");
    numero++;
} while (numero < 10);



for (int i = 0; <= 10; i++)
{
    Console.WriteLine($"Valor de i:{i}");
}