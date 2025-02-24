// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// estrutura de dados vetor array
int[] meuArray = {1,2,3,4,5};

//foreach para percorrer o vetor

foreach (int numero in meuArray)
{
    Console.WriteLine(numero);
}

//estrutura de dados lista
List<string> listaNomes = new List<string>{"Wanderson", "Jeane", "Ryan"};
listaNomes.Add("Maria");

foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}
    Console.WriteLine("");
// remover da lista

listaNomes.Remove("Jeane");

foreach (string nome in listaNomes)
{
    Console.WriteLine(nome);
}      

//estrutura de dados conjunto (set)
HashSet<int> conjunto = new HashSet<int>{1,2,3};
conjunto.Add(4);

foreach (int numero in conjunto)
{
    Console.WriteLine(numero);
}
Console.WriteLine("");
//adicionar um elemento ja existe

conjunto.Add(2);

foreach (int numero in conjunto)
{
    Console.WriteLine(numero);
}