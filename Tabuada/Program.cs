// ***Faça um programa que leia um  numero inteiro positivo e imprima a sua tabuada***

int n = 0;

do
{
    Console.WriteLine("Digite um numero inteiro e positivo");
    n = int.Parse(Console.ReadLine());
} while (n <= 0);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();