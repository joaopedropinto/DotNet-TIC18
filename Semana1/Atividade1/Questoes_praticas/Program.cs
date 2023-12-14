Console.WriteLine("Atividade pratica 1");
#region Questao 3
Console.WriteLine("\nQuestao 3");

double valDouble = 3.7;
int valInt = (int)valDouble;

Console.WriteLine("Valor Double: " + valDouble);
Console.WriteLine("Valor Inteiro: " + valInt);

// Utilizando a conversão direta de double para int causa a perda da parte fracionária do double, que não
// pode ser representado pelo int. 
#endregion

#region Questao 4

int x = 10, y = 3;
Console.WriteLine("\nQuestao 4");
Console.WriteLine("X = " + x + " e Y = " + y);
Console.WriteLine("Adição: " + (x + y));
Console.WriteLine("Subtração: " + (x - y));
Console.WriteLine("Multiplicação: " + (x * y));
Console.WriteLine("Divisão: " + (x / y));
#endregion

#region Questao 5

Console.WriteLine("\nQuestao 5");
int a = 5;
int b = 8;

if(a > b){
  Console.WriteLine("A e maior que B");
}else{
  Console.WriteLine("B e maior que A");
}
#endregion

#region Questao 6
Console.WriteLine("\nQuestao 6");
string str1 = "Hello",str2 = "World";
Console.WriteLine("Strings: " + str1 + " e " + str2);
if(str1 == str2){
  Console.WriteLine("As duas strings sao iguais");
}else{
  Console.WriteLine("As duas strings sao diferentes");
}
#endregion

#region Questao 7
Console.WriteLine("\nQuestao 7");
bool condicao1 = true, condicao2 = false;

if(condicao1 && condicao2){
  Console.WriteLine("As duas condições são iguais");
}else{
  Console.WriteLine("As duas condições são diferentes");
}
#endregion

#region Questao 8
Console.WriteLine("\nQuestao 8");
int num1 = 7, num2 = 3, num3 = 10;
Console.WriteLine("num1: " + num1 + ", num2: " + num2 + ", num3: " + num3);
if(num1 > num2){
  Console.WriteLine("num 1 e maior que num2");
}
if(num3 == num1 + num2){
  Console.WriteLine("num3 e igual a num1 + num2");
}else{
  Console.WriteLine("num3 e diferente de (num1 + num2");
}
#endregion