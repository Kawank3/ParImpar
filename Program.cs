Console.Write("Digite um número: ");
string entrada = Console.ReadLine()!;

if (int.TryParse(entrada, out int numero))
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero + " é par");
    }
    else
    {
        Console.WriteLine(numero + " é ímpar");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}