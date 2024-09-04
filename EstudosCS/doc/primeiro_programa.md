### Primeiro Programa: "Hello, World!" em C#

#### Introdução

O "Hello, World!" é tradicionalmente o primeiro programa escrito por iniciantes em uma nova linguagem de programação. Ele serve como uma introdução simples, mas prática, ao ambiente de desenvolvimento, mostrando como criar, compilar e executar um programa básico. Neste artigo, você aprenderá a criar seu primeiro programa "Hello, World!" em C#, utilizando o .NET SDK e uma IDE, como Visual Studio ou Visual Studio Code.

#### Criando o Projeto "Hello, World!"

Antes de começar, certifique-se de que você já configurou o ambiente de desenvolvimento, instalando o .NET SDK e escolhendo uma IDE, como discutido em artigos anteriores.

##### 1. Criando o Projeto com o .NET CLI

O .NET CLI (Command Line Interface) permite que você crie e gerencie projetos diretamente do terminal ou prompt de comando. Siga os passos abaixo para criar o projeto "Hello, World!":

1. **Abra o terminal ou prompt de comando**:
   - No Windows: Você pode usar o Prompt de Comando, PowerShell ou o terminal integrado do Visual Studio Code.
   - No macOS/Linux: Use o Terminal.

2. **Navegue até a pasta onde deseja criar o projeto**:
   Use o comando `cd` para navegar até o diretório desejado. Por exemplo:
   ```bash
   cd /caminho/para/pasta
   ```

3. **Crie um novo projeto de console**:
   Execute o comando:
   ```bash
   dotnet new console -n HelloWorld
   ```
   Este comando cria um novo projeto de console em uma pasta chamada `HelloWorld`. A opção `-n` especifica o nome do projeto.

4. **Navegue até a pasta do projeto**:
   ```bash
   cd HelloWorld
   ```

Neste ponto, você tem um projeto básico configurado, pronto para ser editado e executado.

#### Estrutura do Programa "Hello, World!"

Agora, vamos examinar o código gerado automaticamente pelo .NET CLI:

##### 1. Arquivo `Program.cs`

Abra o arquivo `Program.cs` no editor de texto ou IDE de sua escolha. O conteúdo padrão deve ser algo parecido com isto:

```csharp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

Vamos entender cada parte desse código:

- **`using System;`**: Esta linha inclui o namespace `System`, que contém classes básicas como `Console`. O `using` permite que você use essas classes sem precisar escrever o namespace completo.

- **`namespace HelloWorld`**: Um namespace é usado para organizar e agrupar classes relacionadas. Aqui, o namespace `HelloWorld` agrupa a classe `Program`.

- **`class Program`**: Uma classe é um bloco básico de construção no C#. `Program` é a classe principal que contém o código que será executado.

- **`static void Main(string[] args)`**: O método `Main` é o ponto de entrada de um programa em C#. Quando você executa o programa, o código dentro do `Main` é o primeiro a ser executado. `static` significa que este método pertence à classe `Program` e não a uma instância da classe. `void` indica que o método não retorna nenhum valor, e `string[] args` é um parâmetro que pode receber argumentos de linha de comando.

- **`Console.WriteLine("Hello, World!");`**: Esta linha de código imprime o texto "Hello, World!" na tela. `Console` é uma classe do namespace `System` que fornece funcionalidades básicas de entrada e saída. `WriteLine` é um método que escreve uma linha de texto na saída padrão (geralmente o terminal).

#### Executando o Programa

Agora que você entende o código, é hora de executá-lo para ver o resultado.

##### 1. Executando o Programa no Terminal

1. **Certifique-se de estar na pasta do projeto**:
   ```bash
   cd /caminho/para/HelloWorld
   ```

2. **Execute o comando**:
   ```bash
   dotnet run
   ```
   Isso compilará e executará o programa, exibindo a saída no terminal:
   ```
   Hello, World!
   ```

##### 2. Executando o Programa na IDE

Se você estiver usando uma IDE como o Visual Studio ou Visual Studio Code, pode executar o programa diretamente de dentro da IDE:

1. **No Visual Studio**:
   - Abra o projeto `HelloWorld`.
   - Clique em `F5` ou vá em "Debug" > "Start Debugging".
   - A saída "Hello, World!" será exibida na janela do console.

2. **No Visual Studio Code**:
   - Abra a pasta `HelloWorld`.
   - Abra o terminal integrado (`Ctrl + `).
   - Execute o comando `dotnet run`.
   - A saída aparecerá no terminal integrado.

#### Personalizando o Programa

Agora que você sabe como criar e executar um programa básico em C#, experimente fazer pequenas alterações:

- **Alterando a mensagem**: Substitua o texto "Hello, World!" por outra mensagem, como:
  ```csharp
  Console.WriteLine("Bem-vindo ao C#!");
  ```
  Execute novamente para ver a nova mensagem.

- **Adicionando mais linhas**: Adicione mais comandos `Console.WriteLine` para exibir mensagens diferentes.

#### Conclusão

Escrever e executar um programa "Hello, World!" é um passo simples, mas fundamental para aprender qualquer nova linguagem de programação. Em C#, esse exemplo introduz você aos conceitos básicos da linguagem e à estrutura de um programa típico. Agora que você já passou por esse primeiro passo, pode continuar explorando o C# com confiança e começar a construir programas mais complexos.