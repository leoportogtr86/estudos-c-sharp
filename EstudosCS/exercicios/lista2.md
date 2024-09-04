Aqui est� uma lista de 20 exerc�cios baseados no artigo sobre a estrutura de um programa em C#: namespaces, classes e m�todos.

### Exerc�cios de Namespaces

1. **Cria��o de Namespace**: Crie um novo namespace chamado `MinhaAplicacao` e defina uma classe dentro dele chamada `Produto`.
2. **Importa��o de Namespace**: Crie um namespace chamado `Servicos`. Dentro dele, crie uma classe `CalculoFrete` e importe esse namespace em outra classe para utiliz�-la.
3. **Aninhamento de Namespaces**: Crie um namespace `Empresa` e, dentro dele, crie um namespace `RH`. Defina uma classe `Funcionario` dentro do namespace `RH`.
4. **Nome Completo**: Acesse uma classe dentro de um namespace sem usar a diretiva `using`, utilizando o nome completo da classe (ex: `System.Console.WriteLine`).

### Exerc�cios de Classes

5. **Defini��o de Classe**: Crie uma classe `Carro` com propriedades `Marca`, `Modelo` e `Ano`.
6. **Inst�ncia de Classe**: Crie uma inst�ncia da classe `Carro` e defina valores para as propriedades `Marca`, `Modelo` e `Ano`.
7. **Propriedades Autom�ticas**: Na classe `Carro`, use propriedades autom�ticas para definir as propriedades `Marca`, `Modelo` e `Ano`.
8. **Propriedade com L�gica**: Adicione uma propriedade `IdadeDoCarro` na classe `Carro`, que calcula a idade do carro com base no ano atual.
9. **M�todos na Classe**: Adicione um m�todo `ExibirInformacoes` na classe `Carro`, que exibe as informa��es do carro no console.
10. **M�todo Construtor**: Adicione um construtor na classe `Carro` que inicializa as propriedades `Marca`, `Modelo` e `Ano` quando um objeto � criado.
11. **Heran�a**: Crie uma classe `Veiculo` com propriedades b�sicas como `VelocidadeMaxima`. Crie a classe `Carro` que herda de `Veiculo` e adiciona propriedades espec�ficas.

### Exerc�cios de M�todos

12. **M�todo com Par�metros**: Crie um m�todo `Somar` que recebe dois n�meros inteiros como par�metros e retorna a soma deles.
13. **M�todo sem Retorno**: Crie um m�todo `MostrarMensagem` que exibe uma mensagem no console, mas n�o retorna nenhum valor.
14. **Sobrecarga de M�todos**: Crie um m�todo `Multiplicar` com duas vers�es: uma que multiplica dois n�meros inteiros e outra que multiplica tr�s n�meros inteiros.
15. **M�todo Est�tico**: Crie um m�todo `ConverterParaMaiuscula` que recebe uma string como par�metro e retorna a string em letras mai�sculas. Defina este m�todo como est�tico.
16. **Chamando M�todos**: Crie uma classe `Calculadora` com m�todos para `Somar`, `Subtrair`, `Multiplicar` e `Dividir`. Em outra classe, crie uma inst�ncia de `Calculadora` e chame cada um dos m�todos.
17. **M�todo com Retorno de Objeto**: Crie um m�todo `CriarCarro` que retorna um objeto da classe `Carro` com propriedades definidas.

### Exerc�cios de Estrutura Completa

18. **Classe com Namespace**: Crie um namespace `Biblioteca`, e dentro dele, uma classe `Livro` com propriedades como `Titulo`, `Autor`, `AnoDePublicacao`, e um m�todo `ExibirDetalhes`.
19. **Programa Completo**: Crie um programa completo com namespace, classe e m�todos que simule o cadastro de produtos em uma loja. O programa deve incluir as classes `Produto`, `Estoque` e `Loja`, cada uma com suas respectivas propriedades e m�todos.
20. **Refatora��o**: Refatore um programa existente para organizar as classes em namespaces adequados e melhorar a legibilidade e a modularidade do c�digo.

Esses exerc�cios ajudar�o a refor�ar a compreens�o da estrutura de um programa em C#, permitindo que voc� pratique a cria��o e manipula��o de namespaces, classes e m�todos em diversos cen�rios.