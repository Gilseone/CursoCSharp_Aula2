using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exemplo_Metodos
{
    /// <summary>
    /// Calcular a soma
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    static double? CalcularSoma(double num1, double num2)
    {
        double resultado;
        resultado = num1 + num2;
        return resultado;
    }

    /// <summary>
    /// Calcular a subtração
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    static double? CalcularSubtracao(double num1, double num2)
    {
        double resultado = num1 + num2;
        return resultado;
    }

    /// <summary>
    /// Calcular a multiplicação
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    static double? CalcularMultiplicacao(double num1, double num2)
    {
        return num1 * num2;
    }

    /// <summary>
    /// Calcular a divisão
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    static double? CalcularDivisao(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
        {
            Console.WriteLine("Divisão por zero!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            return null;
        }
    }

    /// <summary>
    /// Função principal
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        double valor1, valor2;
        double? resultado = null;
        string operacao;

        //Fazer a leitura do primeiro valor
        Console.Write("Digite o primeiro valor: ");
        valor1 = Convert.ToDouble(Console.ReadLine());

        //Fazer a leitura da operação
        Console.Write("Digite a operação: ");
        operacao = Console.ReadLine();

        //Fazer a leitura do segundo valor
        Console.Write("Digite o segundo valor: ");
        valor2 = Convert.ToDouble(Console.ReadLine());

        //Estrutura do switch
        switch (operacao)
        {
            case "+":
                resultado = CalcularSoma(valor1, valor2);
                break;
            case "-":
                resultado = CalcularSubtracao(valor1, valor2);
                break;
            case "*":
                resultado = CalcularMultiplicacao(valor1, valor2);
                break;
            case "/":
                resultado = CalcularDivisao(valor1, valor2);
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }

        if (resultado == null)
            Console.WriteLine("Resultado: " + resultado);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
