using System.Diagnostics.CodeAnalysis;

namespace TesteUnitarioFiap.App
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para os cálculos: ");

            Console.Write("Primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            var c = new Calculadora();

            Console.WriteLine("***** RESULTADO *****");

            Console.WriteLine($"Soma: {c.Somar(v1, v2)}");
            Console.WriteLine($"Subtração: {c.Subtrair(v1, v2)}");
            Console.WriteLine($"Multiplicação: {c.Multiplicar(v1, v2)}");
            Console.WriteLine($"Divisão: {c.Dividir(v1, v2)}");
        }
    }
}