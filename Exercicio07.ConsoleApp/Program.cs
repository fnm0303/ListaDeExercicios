/*
O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar
uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso /
(altura) 2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição
de acordo com a listagem abaixo:
IMC em adultos Condição
Abaixo de 18,5 = Abaixo do peso
Entre 18,5 e 25 = Peso normal
Entre 25 e 30 = f. Acima do peso
Acima de 30 = obeso

Fórmula: IMC = PESO / (ALTURA * ALTURA)
*/

Console.Clear();
Console.Write("Digite o seu peso (em kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite a sua altura (em m): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("-------------------------------");
if (imc <= 18.5)
    Console.WriteLine($"Seu IMC é {imc:F2} e você está ABAIXO DO PESO");
else if (imc > 18.5 && imc <= 25)
    Console.WriteLine($"Seu IMC é {imc:F2} e você está com PESO NORMAL");
else if (imc > 25 && imc <= 30)
    Console.WriteLine($"Seu IMC é {imc:F2} e você está ACIMA DO PESO");
else
    Console.WriteLine($"Seu IMC é {imc:F2} e você está OBESO");

Console.ReadLine();
