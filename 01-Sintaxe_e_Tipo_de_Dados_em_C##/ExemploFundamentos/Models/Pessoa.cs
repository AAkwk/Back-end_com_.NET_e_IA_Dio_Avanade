using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public decimal Salario { get; set; }
        //public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, e tenho {Idade} anos. Meu salario e R${Salario}. Eu peso {Peso}Kg e tenho {Altura}cm.");
        }
    }
}
    
