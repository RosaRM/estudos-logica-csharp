using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rafael_Projetos.Models
{
    public class Calculadora
    {
        public void Somar (int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair (int x, int y) 
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Mutiplicar (int x, int y) 
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Dividir (int x, int y) 
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot =Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
    }
}