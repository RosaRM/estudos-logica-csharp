using Rafael_Projetos.Models;


/*DateTime dataAtual = DateTime.Now;

string apresentacao = "Chama, seja bem vindo";

int quantidade = 1;

double altura = 1.710;

decimal preco = 1.80M;

bool condicao = false;

Console.WriteLine (apresentacao);

Console.WriteLine ("Valor da váriavel quantidade: " + quantidade);
Console.WriteLine ("Valor da váriavel altura: " + altura.ToString("0.000"));
Console.WriteLine ("Valor da váriavel preco: " + preco);
Console.WriteLine ("Valor da váriavel condicao: " + condicao);
Console.WriteLine ("Valor da váriavel Data Atual: " + dataAtual);
*/
Pessoa pessoaSabida = new Pessoa();

pessoaSabida.Idade = 22;
pessoaSabida.Nome = "Rafael";

pessoaSabida.Apresentar();