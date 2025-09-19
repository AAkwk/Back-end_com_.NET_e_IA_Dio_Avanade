// 1) OR

// bool eMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada nao liberada!");
// }




// 2) AND

// bool possuiPresencaMinima = false;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }


//3) NOT

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar um outro dia!");
}