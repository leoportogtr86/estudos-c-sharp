using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCS.exercicios
{
    internal class Ex5
    {
        public static void Exec()
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] arrCharacters = palavra.ToCharArray();
            Array.Reverse(arrCharacters);
            string invertida = new string(arrCharacters);

            Console.WriteLine(invertida);
        }
    }
}


// ### Exercício 5: Inversão de String
// -**Descrição * *: Crie um programa que peça ao usuário para inserir uma
// palavra e exiba a palavra ao contrário.
// - **Dica**: Use o método `ToCharArray()` para converter a string em um
// array de caracteres e, em seguida, use `Array.Reverse()`.
