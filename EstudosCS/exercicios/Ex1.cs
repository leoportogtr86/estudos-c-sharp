using System;

namespace EstudosCS.exercicios
{
    internal class Ex1
    {
        public static void Exec()
        {
            Console.WriteLine("Insira um número: ");
            string a = Console.ReadLine();
            int numeroA = int.Parse(a);
            Console.WriteLine("Insira outro número: ");
            string b = Console.ReadLine();
            int numeroB = int.Parse(b);
            int soma = numeroA + numeroB;

            Console.WriteLine(soma);
        }
    }
}

//-**Descrição * *: Escreva um programa que peça ao usuário para inserir dois números
//inteiros e, em seguida, exiba a soma desses números.
//- **Dica**: Use `int.Parse()` para converter a entrada de string para inteiro.

