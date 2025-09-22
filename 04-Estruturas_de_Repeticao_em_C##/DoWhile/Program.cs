
int soma = 0, numero = 0;


do
{
    Console.Write("Digite um numero:");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while (numero != 0);

Console.WriteLine($"Total da soma dos numeros digitados e: {soma}");