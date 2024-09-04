Aqui está uma lista de 20 exercícios baseados no artigo sobre a estrutura de um programa em C#: namespaces, classes e métodos.

### Exercícios de Namespaces

1. **Criação de Namespace**: Crie um novo namespace chamado `MinhaAplicacao` e defina uma classe dentro dele chamada `Produto`.
2. **Importação de Namespace**: Crie um namespace chamado `Servicos`. Dentro dele, crie uma classe `CalculoFrete` e importe esse namespace em outra classe para utilizá-la.
3. **Aninhamento de Namespaces**: Crie um namespace `Empresa` e, dentro dele, crie um namespace `RH`. Defina uma classe `Funcionario` dentro do namespace `RH`.
4. **Nome Completo**: Acesse uma classe dentro de um namespace sem usar a diretiva `using`, utilizando o nome completo da classe (ex: `System.Console.WriteLine`).

### Exercícios de Classes

5. **Definição de Classe**: Crie uma classe `Carro` com propriedades `Marca`, `Modelo` e `Ano`.
6. **Instância de Classe**: Crie uma instância da classe `Carro` e defina valores para as propriedades `Marca`, `Modelo` e `Ano`.
7. **Propriedades Automáticas**: Na classe `Carro`, use propriedades automáticas para definir as propriedades `Marca`, `Modelo` e `Ano`.
8. **Propriedade com Lógica**: Adicione uma propriedade `IdadeDoCarro` na classe `Carro`, que calcula a idade do carro com base no ano atual.
9. **Métodos na Classe**: Adicione um método `ExibirInformacoes` na classe `Carro`, que exibe as informações do carro no console.
10. **Método Construtor**: Adicione um construtor na classe `Carro` que inicializa as propriedades `Marca`, `Modelo` e `Ano` quando um objeto é criado.
11. **Herança**: Crie uma classe `Veiculo` com propriedades básicas como `VelocidadeMaxima`. Crie a classe `Carro` que herda de `Veiculo` e adiciona propriedades específicas.

### Exercícios de Métodos

12. **Método com Parâmetros**: Crie um método `Somar` que recebe dois números inteiros como parâmetros e retorna a soma deles.
13. **Método sem Retorno**: Crie um método `MostrarMensagem` que exibe uma mensagem no console, mas não retorna nenhum valor.
14. **Sobrecarga de Métodos**: Crie um método `Multiplicar` com duas versões: uma que multiplica dois números inteiros e outra que multiplica três números inteiros.
15. **Método Estático**: Crie um método `ConverterParaMaiuscula` que recebe uma string como parâmetro e retorna a string em letras maiúsculas. Defina este método como estático.
16. **Chamando Métodos**: Crie uma classe `Calculadora` com métodos para `Somar`, `Subtrair`, `Multiplicar` e `Dividir`. Em outra classe, crie uma instância de `Calculadora` e chame cada um dos métodos.
17. **Método com Retorno de Objeto**: Crie um método `CriarCarro` que retorna um objeto da classe `Carro` com propriedades definidas.

### Exercícios de Estrutura Completa

18. **Classe com Namespace**: Crie um namespace `Biblioteca`, e dentro dele, uma classe `Livro` com propriedades como `Titulo`, `Autor`, `AnoDePublicacao`, e um método `ExibirDetalhes`.
19. **Programa Completo**: Crie um programa completo com namespace, classe e métodos que simule o cadastro de produtos em uma loja. O programa deve incluir as classes `Produto`, `Estoque` e `Loja`, cada uma com suas respectivas propriedades e métodos.
20. **Refatoração**: Refatore um programa existente para organizar as classes em namespaces adequados e melhorar a legibilidade e a modularidade do código.

Esses exercícios ajudarão a reforçar a compreensão da estrutura de um programa em C#, permitindo que você pratique a criação e manipulação de namespaces, classes e métodos em diversos cenários.