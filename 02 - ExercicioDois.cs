/*Declare três variáveis com notas de um aluno 
(ex: 7.5, 8.0, 6.0) e calcule a média aritmética delas.*/
using System;

string nomeAluno = "Jaiane";
double notaUm = 7.0;
double notaDois = 8.0;
double notaTres =10.0;

double media = (notaUm + notaDois + notaTres) / 3;

if(media>= 6.0){
    Console.WriteLine("A média aritmética do aluno " + nomeAluno + " é de " + media +"\nParabéns, ficou acima da média");
}
else{
    Console.WriteLine("A média aritmética do aluno " + nomeAluno + " é de " + media + "\nOps, acho que não estudou tanto, sua média ficou a baixo da média");
}


// Esse exercício usando listas para as notas e interpolação 



