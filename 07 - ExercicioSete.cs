/*Use o comando Console.ReadLine() para perguntar o nome do usuário e a idade dele. 
Depois, exiba uma mensagem como: "Olá [Nome], você tem [Idade] anos".*/

using System;

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos");

// Fazer uma condição de idade

