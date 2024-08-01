using System.Security.Principal;

namespace calculadora_exercicio_1_semestre_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora(10, 35);
            double resultado = calc.Somar();
            Console.WriteLine(resultado);
        }
    }
}
