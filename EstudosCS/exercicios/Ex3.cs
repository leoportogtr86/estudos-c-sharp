using System.Runtime.Intrinsics.X86;

namespace EstudosCS.exercicios;

public class Ex3
{
    public static void Exec()
    {
        Console.WriteLine("Digite um número: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite uma operação: ");
        string operacao = Console.ReadLine();
        double resultado;

        switch (operacao)
        {
            case "+":
                resultado = a + b;
                break;
            case "-":
                resultado = a - b;
                break;
            case "*":
                resultado = a * b;
                break;
            case "/":
                resultado = a / b;
                break;
            default:
                resultado = 0;
                Console.WriteLine("Operação inválida...");
                break;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}

//### Exercício 3: Calculadora Simples
//- ** Descrição**: Crie um programa que peça ao usuário para inserir dois números e uma operação(adição, subtração, multiplicação ou divisão) e, em seguida, exiba o resultado da operação.
//- **Dica**: Use uma estrutura `switch` para selecionar a operação correta.
