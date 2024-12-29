using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rafael_Projetos.Models
{
    public class Pessoa
    {
      public string? Nome { get; set; }  
      public int Idade { get; set; }

      public void Apresentar()
      {
//        Console.WriteLine($"Olá, meu nome é {Nome}, e minha idade é {Idade}");
        Console.WriteLine($"Olá, meu nome é {Nome}\n" +
        $"E minha idade é {Idade}");
      }
    }
}