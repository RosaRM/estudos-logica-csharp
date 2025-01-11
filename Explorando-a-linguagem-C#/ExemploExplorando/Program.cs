using ExemploExplorando.Models;
using System.Globalization;


















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