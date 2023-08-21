// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("PAR ou IMPAR \n");

Console.WriteLine("Digite um número");

double num = double.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O número " + num + " é par \n");
}
else
{
    Console.WriteLine("O número " + num + " é impar \n");
}