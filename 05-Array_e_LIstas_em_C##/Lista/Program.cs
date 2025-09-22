
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MG");
listaString.Add("MS");
listaString.Add("MT");


Console.WriteLine($"Itens na minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("RO");

Console.WriteLine($"Itens na minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MT");

Console.WriteLine($"Itens na minha Lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Posição com for");
// for (int i = 0; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição N°{i} - {listaString[i]}");
// }


// Console.WriteLine("Posição com foreach");
// int contForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição N°{contForeach} - {item}");
//     contForeach++;
// }