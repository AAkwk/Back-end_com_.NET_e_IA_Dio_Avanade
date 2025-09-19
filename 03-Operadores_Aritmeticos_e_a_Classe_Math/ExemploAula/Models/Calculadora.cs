using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAula.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
        public void Seno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double sin = Math.Sin(rad);
            Console.WriteLine($"Sen({angulo}) = {Math.Round(sin, 2)}");
        }
        public void Coseno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double cos = Math.Cos(rad);
                    Console.WriteLine($"Cos({angulo}) = {Math.Round(cos, 2)}");
        }
        public void Tan(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double tan = Math.Tan(rad);
            Console.WriteLine($"Tan({angulo}) = {Math.Round(tan, 2)}");
        }
    }
}