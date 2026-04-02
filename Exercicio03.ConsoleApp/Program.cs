//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

//Fórmula ((0°C × 9)/5) + 32 = 32 °F

Console.Write("Digite a temperatura em °C: ");
double tempCelsius = Convert.ToDouble(Console.ReadLine());

double tempFahrenheit = ((tempCelsius * 9) / 5) + 32;

Console.WriteLine($"A temperatura de {tempCelsius} °C em Fahrenheit é: {tempFahrenheit} °F.");
Console.ReadLine();

