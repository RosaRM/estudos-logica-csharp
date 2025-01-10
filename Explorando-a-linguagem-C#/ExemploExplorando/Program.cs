using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-20-17 18:00";

bool sucess = DateTime.TryParseExact(dataString , "yyyy-MM-dd HH:mm",  CultureInfo.InvariantCulture , DateTimeStyles.None , out DateTime data);

// DateTime data = DateTime.Parse(dataString);
if (sucess)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{data} Não é uma data valida!");
}





















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 83.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 1256;

// Console.WriteLine(numero.ToString("##-##"));





// string numero1 = "10";
// string numero2 = "20"

// string result = numero1 + numero2;

// Console.WriteLine(resultado);

















// Pessoa p1 = new Pessoa(nome:  "Roger", sobrenome: "Guedes");
// Pessoa p2 = new Pessoa(nome: "Luiz",sobrenome: "Turco");

// Curso ingles = new Curso();
// ingles.Nome = "Ingles";
// ingles.Alunos = new List<Pessoa>();

// ingles.AdiocionarAluno(p2);
// ingles.AdiocionarAluno(p1);
// ingles.ListarAlunos();



// Pessoa p1 = new Pessoa();

// p1.Nome = "Roger";
// p1.Idade = 21;
// p1.Sobrenome = "Guedes";
// p1.Apresentar();