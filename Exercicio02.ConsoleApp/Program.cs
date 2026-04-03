/*
Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
O programa deve solicitar ao usuário:
a. A quilometragem inicial do veículo no início da viagem.
b. A quilometragem final ao término da viagem.
c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.Clear();
Console.Write("Digite a quilometragem do veículo no início da viagem: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quilometragem do veículo ao término da viagem: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de combustível consumida durante a viagem (em litros): ");
double qtdCombustivel = Convert.ToDouble(Console.ReadLine());

double kmRodado = kmFinal - kmInicial;

double mediaCombustivel = kmRodado / qtdCombustivel;

Console.WriteLine($"A média de consumo de combustível durante a viagem foi: {mediaCombustivel:F2} km/l");
Console.ReadLine();