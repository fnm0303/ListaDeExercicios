//Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Clear();
Console.Write("Digite um número inteiro qualquer: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("------------------------------");
if (numero % 2 == 0)
    Console.WriteLine($"O número {numero} é PAR.");
else
    Console.WriteLine($"O número {numero} é ÍMPAR.");

Console.ReadLine();