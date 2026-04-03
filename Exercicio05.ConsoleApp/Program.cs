//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno



Console.Write("Digite a 1ª nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite a 2ª nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

double mediaPonderada = ((nota1 * 7) + (nota2 * 3)) / 10;

Console.WriteLine($"A média ponderada do aluno, com base na: \nnota 1 = {nota1:F2} (peso 7) e \nnota 2 = {nota2} (peso 3) \nSerá: {mediaPonderada:F2}");

Console.ReadLine();