using System.ComponentModel;
using Rafael_Projetos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista:  {listaString.Count} - {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista:  {listaString.Count} - {listaString.Capacity}");

listaString.Add("MG");

Console.WriteLine($"Itens na minha lista:  {listaString.Count} - {listaString.Capacity}");


// Console.WriteLine("Lista FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Lista FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
//     contadorForeach++;

// }
















// int[] arrayInteiros = new int[5];
// arrayInteiros[0] = 45;
// arrayInteiros [1]= 65;
// arrayInteiros [2] = 95;
// arrayInteiros [3] = 135;
// arrayInteiros [4] = 185;

//     Console.WriteLine($"{arrayInteiros.Length}");
// int [] arrayInteirosDobrados = new int [arrayInteiros.Length *2]; 
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// int contadorForeach =0;
//  foreach(int val in arrayInteiros)
//  {
//         //  Console.WriteLine($"Esté é o valor na ordem: {val}");
//         Console.WriteLine($"Esté é o valor na posição {contadorForeach} : {val}");
//          contadorForeach++;
//  }
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Esté é o valor na posição {contador} : {arrayInteiros[contador]}");
// }







// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Roger";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();


/*
int soma = 0, numero = 0;
do
{

    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
}while(numero != 0);

    Console.WriteLine($"Esta é a soma realizada {soma}");*/


/*
int numero = 10;
int contador = 0;

while (contador <= 10 ){
    
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
*/

/*
for(int contador =0; contador <= 10; contador++)
{

    Console.WriteLine($"{numero} x {contador} = {numero * contador}");

}
*/


/* Calculadora calc = new Calculadora();


calc.RaizQuadrada(2025);*/
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
//calc.Potencia(23, 3);
/*
calc.Somar(5,20);
calc.Subtrair(34, 45);
calc.Mutiplicar(43, 6);
calc.Dividir(42, 12);
*/
/*
int numero = 10;
int num = 10;

Console.WriteLine(numero);

Console.WriteLine("Incrementando o 10");
numero++;

Console.WriteLine("Decrementando o 10");
num--;

Console.WriteLine(num);
*/
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
/*
Pessoa pessoaSabida = new Pessoa();

pessoaSabida.Idade = 22;
pessoaSabida.Nome = "Rafael";

pessoaSabida.Apresentar();
*/
