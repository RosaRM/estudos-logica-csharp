using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;



Pessoa p1 = new Pessoa (nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = p1;

p2.Nome = "Roger";

Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");











// int numero = 24;
// bool ehPar = false;

// //If Ternário
// ehPar = numero.EhPar();
// Console.WriteLine($"O número {numero} é " + ( ehPar ? "par": "ímpar"));






















// MeuArray<int> listaInt = new MeuArray<int>();

// listaInt.AdiocionarElementoArray(30);

// Console.WriteLine(listaInt[0]);



// MeuArray<string> listastring = new MeuArray<string>();

// listastring.AdiocionarElementoArray("POKEMANIAA");

// Console.WriteLine(listastring[0]);











// dynamic varivelDinamica = 4;

// Console.WriteLine($"Tipo da variavel: {varivelDinamica.GetType()}, Valor: {varivelDinamica}");

// varivelDinamica = "texto";
// Console.WriteLine($"Tipo da variavel: {varivelDinamica.GetType()}, Valor: {varivelDinamica}");
















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listVenda.Select(x => new { x.Produto, x.Preco});


// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
// }










// var tipoAnonimo = new { Nome = "Nibole", Sobrenome = "Rosa", Altura = 1.10};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);


















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listVenda)
// {
//     Console.WriteLine($"Id: {venda.Id} , Produto: {venda.Produto} , Preço: {venda.Preco} , Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")} {(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
// }


















// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuario optou por receber email");
// }
// else
// {
//     Console.WriteLine("O usuario optou por não receber email ou não respomdeu");
// }














// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Celular", 1950.5M, DateTime.Now);
// Venda v2 = new Venda(2, "Tablet", 1250.5M, DateTime.Now);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

































// if (numero % 2 ==0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }













































// Pessoa p1 = new Pessoa(  "Roger",  "Guedes");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");






























// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) =arquivo.LerArquivo("rquivos/Arquivoleitura.txt");


// if (sucesso)
// {
//     // Console.WriteLine($"Quantiodade linhas de arquivo: {quantidadedeLinhas}");
//     foreach(string linhas in linhasArquivo)
//     {
//         Console.WriteLine($"{linhas}");
//     }
// }
// else 
// {
//     Console.WriteLine($" Não foi possivel realizar a leitura> {sucesso}");

// }



// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (32, "rafael" , "mayumi", 10.5M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");


// ValueTuple<int ,string, string, decimal> outroEX = (34 , "Nicole" , "macedo" , 161.5M);
// // var outroEx = Tuple.Create(32, "rafael" , "mayumi" , 10.5M);
// var outroEx = Tuple.Create(34 , "Nicole" , "macedo" , 161.5M);

// Console.WriteLine($"Id: {outroEX.Item1}");
// Console.WriteLine($"Nome: {outroEX.Item2}");
// Console.WriteLine($"Sobrenome: {outroEX.Item3}");
// Console.WriteLine($"Altura: {outroEX.Item4}");


























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP" , "São Paulo");
// estados.Add("BA" , "Bahia");
// estados.Add("RS" , "Rio Grande do Sul");

// Console.WriteLine(estados["SP"]);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
// }


// Console.WriteLine("-----------------------");
// estados.Remove("BA");
// estados["RS"] = "Rio Pequeno do norte";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elelmento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// } else 
// {
//         Console.WriteLine($"Valor inexistente, é segurp adicionar a chave{chave}");

// }



// Stack<int> pilha = new Stack<int>();


// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

//  Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

// pilha.Push(00);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }






// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(1);


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(10);
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }









// ExemploExecao EX =  new ExemploExecao();
// EX.Metodo1();




// try 
// {
// string [] linhas = File.ReadAllLines("Arquivos/Arquivoleitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Pasta não encontrada {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }











// string dataString = "2022-20-17 18:00";

// bool sucess = DateTime.TryParseExact(dataString , "yyyy-MM-dd HH:mm",  CultureInfo.InvariantCulture , DateTimeStyles.None , out DateTime data);

// // DateTime data = DateTime.Parse(dataString);
// if (sucess)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{data} Não é uma data valida!");
//}





















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