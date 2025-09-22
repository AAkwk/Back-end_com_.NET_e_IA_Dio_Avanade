

using System.Diagnostics.Contracts;

int numero = 10;
int i = 0;


while (i <= 10)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
    i++;
    if (i == 6)
    {
        break;
    }
}