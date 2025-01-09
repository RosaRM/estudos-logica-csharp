using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdiocionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatrículados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
          return Alunos.Remove(aluno);
             
        }

        public void ListarAlunos()
        {

            Console.WriteLine($"Alunos do curso de {Nome}")
            for (int coun = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº" + (count + 1) + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
        }
    }
}