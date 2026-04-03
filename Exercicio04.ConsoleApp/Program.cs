/*
Crie um programa para calcular o salário total de um vendedor. 
Deverá ser informado o salário base e o total de vendas. 
A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
*/

//Salário Total = Salário Fixo + (Total de Vendas * Porcentagem de Comissão)

Console.Clear();
Console.Write("Digite o salário base do funcionário (em R$): ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite o total de vendas do funcionário (em R$): ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("\nDigite a porcentagem de comissão do funcionário: ");
double porcentagemVendas = Convert.ToDouble(Console.ReadLine());

double salarioTotal = salarioBase + (totalVendas * (porcentagemVendas / 100));
Console.WriteLine($"\nO salário total do funcionário será R$: {salarioTotal:F2}");

Console.ReadLine();