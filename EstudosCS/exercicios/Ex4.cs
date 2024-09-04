using System.Runtime.Intrinsics.X86;

namespace EstudosCS.exercicios;

public class Ex4
{
    public static void Exec()
    {
        Console.WriteLine("Insira um numero: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} X {i} = {num * i}");
        }
    }
}

//### Exercício 4: Tabuada
//- ** Descrição**: Escreva um programa que peça ao usuário para inserir um número e,
// em seguida, exiba a tabuada desse número de 1 a 10.
//- ** Dica**: Use um loop `for` para iterar de 1 a 10 e multiplicar pelo número fornecido.

