using System.Runtime.Intrinsics.X86;

namespace EstudosCS.exercicios;

public class Ex2
{
    public static void Exec()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Par");
        }
        else
        {
            Console.WriteLine("Ímpar");
        }
    }
}

//### Exercício 2: Verificação de Número Par ou Ímpar
//- ** Descrição**: Escreva um programa que peça ao usuário para inserir um
//número inteiro e verifique se o número é par ou ímpar.
//- ** Dica**: Use o operador `%` para verificar o resto da divisão por 2.
