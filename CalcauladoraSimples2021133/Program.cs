// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vamos calcular?");
Console.WriteLine("Informe o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha uma opção");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Dividir");
Console.WriteLine("4 - Multiplicar");
Console.WriteLine("Informe: ");

double opcao = Convert.ToDouble(Console.ReadLine());

switch (opcao)
{
    case 1:
        double resultadoSoma = new CalculosSimples().Somar(numero1, numero2);
        Console.WriteLine($"{numero1} + {numero2} = {resultadoSoma}");
        break;
    case 2:
        double resultadoSubtracao = new CalculosSimples().Subtrair(numero1, numero2);
        Console.WriteLine($"{numero1} - {numero2} = {resultadoSubtracao}");
        break;
    case 3:
        double resultadoDivisao = new CalculosSimples().Dividir(numero1, numero2);
        Console.WriteLine($"{numero1} / {numero2} = {resultadoDivisao}");
        break;
    case 4:
        double resultadoMultiplicacao = new CalculosSimples().Multiplicar(numero1, numero2);
        Console.WriteLine($"{numero1} * {numero2} = {resultadoMultiplicacao}"); 
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}

