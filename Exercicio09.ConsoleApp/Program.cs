/*
Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo
de A! e o seu resultado.
a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
b. Pesquise sobre “fatorial”
*/

using System.Numerics;

Console.Clear();
Console.Write("Digite um número para calcular o FATORIAL: ");
int numero = Convert.ToInt32(Console.ReadLine());
BigInteger resultado = numero; //para armazenar valores muito altos

for (int i = numero - 1; i >= 1; i--)
{
    resultado = resultado * i;
}

Console.WriteLine("-------------------------------------------");
Console.WriteLine($"O fatorial de {numero}! é = {resultado:N0}"); //N0 para fazer a separação de milhar
Console.ReadLine();
