### Primeiro Programa: "Hello, World!" em C#

#### Introdu��o

O "Hello, World!" � tradicionalmente o primeiro programa escrito por iniciantes em uma nova linguagem de programa��o. Ele serve como uma introdu��o simples, mas pr�tica, ao ambiente de desenvolvimento, mostrando como criar, compilar e executar um programa b�sico. Neste artigo, voc� aprender� a criar seu primeiro programa "Hello, World!" em C#, utilizando o .NET SDK e uma IDE, como Visual Studio ou Visual Studio Code.

#### Criando o Projeto "Hello, World!"

Antes de come�ar, certifique-se de que voc� j� configurou o ambiente de desenvolvimento, instalando o .NET SDK e escolhendo uma IDE, como discutido em artigos anteriores.

##### 1. Criando o Projeto com o .NET CLI

O .NET CLI (Command Line Interface) permite que voc� crie e gerencie projetos diretamente do terminal ou prompt de comando. Siga os passos abaixo para criar o projeto "Hello, World!":

1. **Abra o terminal ou prompt de comando**:
   - No Windows: Voc� pode usar o Prompt de Comando, PowerShell ou o terminal integrado do Visual Studio Code.
   - No macOS/Linux: Use o Terminal.

2. **Navegue at� a pasta onde deseja criar o projeto**:
   Use o comando `cd` para navegar at� o diret�rio desejado. Por exemplo:
   ```bash
   cd /caminho/para/pasta
   ```

3. **Crie um novo projeto de console**:
   Execute o comando:
   ```bash
   dotnet new console -n HelloWorld
   ```
   Este comando cria um novo projeto de console em uma pasta chamada `HelloWorld`. A op��o `-n` especifica o nome do projeto.

4. **Navegue at� a pasta do projeto**:
   ```bash
   cd HelloWorld
   ```

Neste ponto, voc� tem um projeto b�sico configurado, pronto para ser editado e executado.

#### Estrutura do Programa "Hello, World!"

Agora, vamos examinar o c�digo gerado automaticamente pelo .NET CLI:

##### 1. Arquivo `Program.cs`

Abra o arquivo `Program.cs` no editor de texto ou IDE de sua escolha. O conte�do padr�o deve ser algo parecido com isto:

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

Vamos entender cada parte desse c�digo:

- **`using System;`**: Esta linha inclui o namespace `System`, que cont�m classes b�sicas como `Console`. O `using` permite que voc� use essas classes sem precisar escrever o namespace completo.

- **`namespace HelloWorld`**: Um namespace � usado para organizar e agrupar classes relacionadas. Aqui, o namespace `HelloWorld` agrupa a classe `Program`.

- **`class Program`**: Uma classe � um bloco b�sico de constru��o no C#. `Program` � a classe principal que cont�m o c�digo que ser� executado.

- **`static void Main(string[] args)`**: O m�todo `Main` � o ponto de entrada de um programa em C#. Quando voc� executa o programa, o c�digo dentro do `Main` � o primeiro a ser executado. `static` significa que este m�todo pertence � classe `Program` e n�o a uma inst�ncia da classe. `void` indica que o m�todo n�o retorna nenhum valor, e `string[] args` � um par�metro que pode receber argumentos de linha de comando.

- **`Console.WriteLine("Hello, World!");`**: Esta linha de c�digo imprime o texto "Hello, World!" na tela. `Console` � uma classe do namespace `System` que fornece funcionalidades b�sicas de entrada e sa�da. `WriteLine` � um m�todo que escreve uma linha de texto na sa�da padr�o (geralmente o terminal).

#### Executando o Programa

Agora que voc� entende o c�digo, � hora de execut�-lo para ver o resultado.

##### 1. Executando o Programa no Terminal

1. **Certifique-se de estar na pasta do projeto**:
   ```bash
   cd /caminho/para/HelloWorld
   ```

2. **Execute o comando**:
   ```bash
   dotnet run
   ```
   Isso compilar� e executar� o programa, exibindo a sa�da no terminal:
   ```
   Hello, World!
   ```

##### 2. Executando o Programa na IDE

Se voc� estiver usando uma IDE como o Visual Studio ou Visual Studio Code, pode executar o programa diretamente de dentro da IDE:

1. **No Visual Studio**:
   - Abra o projeto `HelloWorld`.
   - Clique em `F5` ou v� em "Debug" > "Start Debugging".
   - A sa�da "Hello, World!" ser� exibida na janela do console.

2. **No Visual Studio Code**:
   - Abra a pasta `HelloWorld`.
   - Abra o terminal integrado (`Ctrl + `).
   - Execute o comando `dotnet run`.
   - A sa�da aparecer� no terminal integrado.

#### Personalizando o Programa

Agora que voc� sabe como criar e executar um programa b�sico em C#, experimente fazer pequenas altera��es:

- **Alterando a mensagem**: Substitua o texto "Hello, World!" por outra mensagem, como:
  ```csharp
  Console.WriteLine("Bem-vindo ao C#!");
  ```
  Execute novamente para ver a nova mensagem.

- **Adicionando mais linhas**: Adicione mais comandos `Console.WriteLine` para exibir mensagens diferentes.

#### Conclus�o

Escrever e executar um programa "Hello, World!" � um passo simples, mas fundamental para aprender qualquer nova linguagem de programa��o. Em C#, esse exemplo introduz voc� aos conceitos b�sicos da linguagem e � estrutura de um programa t�pico. Agora que voc� j� passou por esse primeiro passo, pode continuar explorando o C# com confian�a e come�ar a construir programas mais complexos.