//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C

Console.Write("Digite o valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de C: ");
int valorC = Convert.ToInt32(Console.ReadLine());

if (valorA + valorB < valorC)
{
    Console.WriteLine($"O valor de A+B é menor do que C.");
    Console.ReadLine();
}

else
    Console.ReadLine();
