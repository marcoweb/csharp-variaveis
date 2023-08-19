// See https://aka.ms/new-console-template for more information
int num = 10;
var num2 = "20"; // Tipagem Automática
num2 = "Olá Mundo!!!";

int numA = 10;
int numB = 2;

int numC = numA;

numA = 30;

Console.WriteLine(numA);
Console.WriteLine(numC);


byte b = 2;

Aluno al = new Aluno();
al.nome = "Marco";
al.idade = 43;

Aluno al2 = al;

al.nome = "Fulano";

Console.WriteLine(al.nome);
Console.WriteLine(al2.nome);
// 00000010 Menor valor: 0
// 11111111 Maior Valor: 255