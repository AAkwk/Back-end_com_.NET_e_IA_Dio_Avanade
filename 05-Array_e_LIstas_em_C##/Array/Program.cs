
using System.Diagnostics.Contracts;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 34;
arrayInteiros[1] = 24;
arrayInteiros[2] = 14;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição N°{i} - {arrayInteiros[i]}");
}
Console.WriteLine("Array Inteiros Dobrados");
for (int i = 0; i < arrayInteirosDobrados.Length; i++)
{
    Console.WriteLine($"Posição N°{i} - {arrayInteirosDobrados[i]}");
}

// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }