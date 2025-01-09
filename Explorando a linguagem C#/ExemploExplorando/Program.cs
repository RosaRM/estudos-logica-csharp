using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:  "Roger", sobrenome: "Guedes");
Pessoa p2 = new Pessoa(nome: "Luiz",sobrenome: "Turco");

Curso ingles = new Curso();
ingles.Nome = "Ingles";
ingles.Alunos = new List<Pessoa>();

ingles.AdiocionarAluno(p2);
ingles.AdiocionarAluno(p1);
ingles.ListarAlunos();



// Pessoa p1 = new Pessoa();

// p1.Nome = "Roger";
// p1.Idade = 21;
// p1.Sobrenome = "Guedes";
// p1.Apresentar();