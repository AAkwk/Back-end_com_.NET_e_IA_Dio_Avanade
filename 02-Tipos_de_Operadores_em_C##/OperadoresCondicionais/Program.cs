
// using System.Numerics;
// using System.Reflection.Metadata;
// using System.Runtime.InteropServices;

// int quantidadeDeEstoque = 10;
// int quantidadeDeCompra = 0;
// bool possivelVenda = quantidadeDeCompra > 0 && quantidadeDeEstoque >= quantidadeDeCompra ;

// Console.WriteLine($"Quantidade em estoque: {quantidadeDeEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeDeCompra}");
// Console.WriteLine($"E possivel realizar a venda? {possivelVenda}");

// if (quantidadeDeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe. Nao temos a quantidade desejada no estoque.");
// }


//2)switch case


Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"E uma vogal");
        break;

    default:
        Console.WriteLine($"Nao e uma vogal");
        break;
}

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine($"E uma vogal");
// }
// else
// {
//      Console.WriteLine($"Nao e uma vogal");
// }



// if (letra == "a"))
// {
//     Console.WriteLine($"E uma vogal");
// }
// else if (letra == "a"))
// {
//   Console.WriteLine($"E uma vogal");  
// }

// else if (letra == "e"))
// {
//   Console.WriteLine($"E uma vogal");  
// }

// else if (letra == "i"))
// {
//   Console.WriteLine($"E uma vogal");  
// }

// else if (letra == "o"))
// {
//     Console.WriteLine($"E uma vogal");
// }

// else if (letra == "u"))
// {
//     Console.WriteLine($"E uma vogal");
// }
// else
// {
//     Console.WriteLine($"Nao e uma vogal");
// }