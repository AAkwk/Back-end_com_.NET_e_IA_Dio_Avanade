//1)Introducao operador de atribuicao
using System.Globalization;

int a = 0;
int b = 3;

int c = a + b;

Console.WriteLine(c);

//2)Combinando operadores
int d = 2;
int e = 5;

int f = d + e;

//f = f + 5;

f += 5;
e -= 2;

Console.WriteLine(f);

Console.WriteLine(e);


//3)Convertendo tipos de variaveis

//  Cast - Casting
int g = Convert.ToInt32("5");
int h = int.Parse("5");

Console.WriteLine(g);
Console.WriteLine(h);

//4) Diferenca entre Covert e Parse

//O PARSE: todos os tipos pode ser covertido para outro tipo.
//O tratamento de valores null. O CONVERT, ele aceita valores nulo, ja o Parse enceerra o programa.
//e mas aceitavel utilizar o Convert

//5) Conversao para sting
int inteiro = 5;
string i = inteiro.ToString();

Console.WriteLine(i);

//6) Cast implicito

// int j = 5;
// double k = j;

// long j = long.MaxValue;
// int k = Convert.ToInt32(j);

int j = int.MaxValue;
long k = j;


Console.WriteLine(k);

//7) Ordem dos operadores

// double l = 4 / 2 + 2;
double l = 4 / (2 + 2);


Console.WriteLine(l);

//8) Convertendo de maneira segura
string m = "5-";

int n = 0;
int.TryParse(m, out n);

Console.WriteLine(m);
Console.WriteLine('Conversao realizada com sucesso!');
