/*Baseado no Exercício 2, faça o programa exibir "Aprovado"
 se a média for maior ou igual a 7, e "Reprovado" caso contrário.*/
using System;

Console.WriteLine("Digite a primeira nota: ");
double notaUm = double.Parse( Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
double notaDois = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
double notaTres = double.Parse(Console.ReadLine());

double media = (notaUm + notaDois + notaTres)/ 3;


if(media > 6.0){
  Console.WriteLine("Passou, sua média foi de " + media);
}
else{
    Console.WriteLine("Reprovou, sua média foi de " + media);
}


  