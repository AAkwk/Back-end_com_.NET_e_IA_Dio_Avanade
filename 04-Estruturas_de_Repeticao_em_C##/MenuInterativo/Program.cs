using System.Runtime.InteropServices.Marshalling;

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opcao:");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Casdatro de cliente.");
            break;
        case "2":
            Console.WriteLine("Busca de cliente.");
            break;
        case "3":
            Console.WriteLine("Apagar cliente.");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opcao Invalida!");
            break;
    }
}