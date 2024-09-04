### Estrutura de um Programa C#: Namespaces, Classes e Métodos

#### Introdução

A estrutura de um programa em C# é fundamental para organizar o código, garantir a modularidade e facilitar a manutenção e a reutilização. Compreender como funcionam namespaces, classes e métodos é essencial para qualquer desenvolvedor que deseja escrever código limpo e eficiente em C#. Neste artigo, exploraremos esses três elementos fundamentais e como eles se interrelacionam para formar a base de um programa em C#.

#### Namespaces

Um **namespace** é uma forma de organizar classes, interfaces, enumerações e outros namespaces em grupos lógicos. Ele ajuda a evitar conflitos de nomes entre diferentes partes de um programa ou entre diferentes bibliotecas. Em C#, um namespace é declarado com a palavra-chave `namespace`, seguida pelo nome do namespace.

**Exemplo de Namespace**:

```csharp
namespace MeuProjeto
{
    class MinhaClasse
    {
        // Código da classe aqui
    }
}
```

- **Importando Namespaces**: Para usar uma classe ou método que está definido em outro namespace, você deve importá-lo usando a diretiva `using` no início do arquivo.

```csharp
using System;

namespace MeuProjeto
{
    class MinhaClasse
    {
        // Código aqui pode usar classes do namespace System
    }
}
```

No exemplo acima, `System` é um namespace padrão no .NET que contém classes básicas como `Console`.

#### Classes

Uma **classe** em C# é um modelo para criar objetos. Ela define um conjunto de propriedades, métodos e eventos que um objeto pode ter. Em outras palavras, a classe é uma estrutura que descreve o comportamento e os estados de seus objetos.

**Estrutura Básica de uma Classe**:

```csharp
public class Pessoa
{
    // Propriedades (ou atributos) da classe
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Método (ou comportamento) da classe
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}
```

- **Propriedades**: Representam os atributos ou dados de uma classe. No exemplo acima, `Nome` e `Idade` são propriedades da classe `Pessoa`.
  
- **Métodos**: São as ações ou comportamentos que uma classe pode realizar. O método `ExibirInformacoes` imprime as informações da pessoa no console.

- **Construtores**: São métodos especiais que são chamados quando uma nova instância da classe é criada. Eles são usados para inicializar as propriedades de um objeto.

**Exemplo de Construtor**:

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}
```

Neste exemplo, o construtor `Pessoa` é usado para inicializar as propriedades `Nome` e `Idade` quando um novo objeto `Pessoa` é criado.

#### Métodos

Um **método** em C# é um bloco de código que contém uma série de instruções. Os métodos são usados para realizar operações em dados e são definidos dentro de uma classe. Um método pode ou não retornar um valor, e pode ou não receber parâmetros.

**Estrutura Básica de um Método**:

```csharp
public void Saudacao()
{
    Console.WriteLine("Olá, seja bem-vindo!");
}
```

- **Modificadores de Acesso**: O modificador `public` torna o método acessível a partir de outras classes. Outros modificadores incluem `private`, `protected`, e `internal`.

- **Tipo de Retorno**: Indica o tipo de dado que o método retorna. O tipo `void` significa que o método não retorna nada. Se um método retorna um valor, você especifica o tipo de retorno, por exemplo, `int`, `string`, etc.

- **Parâmetros**: São dados que você passa para o método para que ele possa usá-los em suas operações. Um método pode ter nenhum, um ou vários parâmetros.

**Exemplo de Método com Retorno e Parâmetro**:

```csharp
public int Somar(int a, int b)
{
    return a + b;
}
```

Neste exemplo, o método `Somar` recebe dois parâmetros (`a` e `b`) e retorna a soma desses dois números.

#### Estrutura Completa de um Programa C#

Agora que entendemos os elementos fundamentais, vejamos como eles se integram em um programa C# completo:

```csharp
using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("João", 25);
            pessoa.ExibirInformacoes();

            int resultado = Somar(10, 20);
            Console.WriteLine("Resultado da soma: " + resultado);
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
```

- **Namespace**: `MeuProjeto` agrupa todas as classes do programa.
- **Classe `Program`**: Contém o ponto de entrada `Main`, onde a execução do programa começa.
- **Método `Main`**: Cria uma instância da classe `Pessoa`, exibe suas informações e chama o método `Somar` para realizar uma operação.
- **Classe `Pessoa`**: Define as propriedades e métodos relacionados à pessoa.
- **Método `Somar`**: Está definido dentro da classe `Program` e é chamado a partir do método `Main`.

#### Conclusão

A estrutura de um programa em C# é composta por namespaces, classes e métodos, que trabalham juntos para criar um código organizado e funcional. Namespaces ajudam a evitar conflitos de nomes, classes definem a estrutura e o comportamento dos objetos, e métodos realizam operações específicas. Entender como esses elementos se relacionam é essencial para desenvolver software de qualidade em C#.