//1. Crie um programa para calcular o volume de uma caixa retangular

//v = c x l x a

Console.Clear();
Console.Write("Digite o comprimento da caixa retangular (em cm): ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é: {volume:F2} cm³ ou {volume / 1000:F2} litros.");

Console.ReadLine();

