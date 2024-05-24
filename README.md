# Testes Unitários - Desafio

Este repositório contém testes unitários para as classes `ValidacoesString` e `ValidacoesLista` do Desafio.

## Estrutura dos Testes

### ValidacoesStringTests

Esta classe contém testes para validar operações relacionadas a strings.

#### DeveRetornar6QuantidadeCaracteresDaPalavraMatrix

Testa o método `RetornarQuantidadeCaracteres` para verificar se retorna corretamente a quantidade de caracteres de uma palavra.

#### DeveContemAPalavraQualquerNoTexto

Verifica se o método `ContemCaractere` retorna verdadeiro quando a palavra procurada está presente no texto.

#### NaoDeveConterAPalavraTesteNoTexto

Testa se o método `ContemCaractere` retorna falso quando a palavra procurada não está presente no texto.

#### TextoDeveTerminarComAPalavraProcurado

Verifica se o método `TextoTerminaCom` retorna verdadeiro quando o texto termina com a palavra procurada.

## ValidacoesListaTests

Esta classe contém testes para validar operações relacionadas a listas de números inteiros.

#### DeveRemoverNumerosNegativosDeUmaLista

Testa o método `RemoverNumerosNegativos` para garantir que remove corretamente os números negativos de uma lista.

#### DeveConterONumero9NaLista

Verifica se o método `ListaContemDeterminadoNumero` retorna verdadeiro quando o número procurado está presente na lista.

#### NaoDeveConterONumero10NaLista

Testa se o método `RemoverNumerosNegativos` não contém o número especificado após a remoção dos negativos.

#### DeveMultiplicarOsElementosDaListaPor2

Verifica se o método `MultiplicarNumerosLista` multiplica corretamente todos os elementos da lista por um número fornecido.

#### DeveRetornar9ComoMaiorNumeroDaLista

Testa se o método `RetornarMaiorNumeroLista` retorna corretamente o maior número da lista.

#### DeveRetornarOitoNegativoComoMenorNumeroDaLista

Verifica se o método `RetornarMenorNumeroLista` retorna corretamente o menor número negativo da lista.

## Como Executar os Testes

Para executar os testes, certifique-se de ter um ambiente configurado com um framework de testes compatível com C# (por exemplo, xUnit, NUnit, MSTest).

1. Clone este repositório para sua máquina local.
2. Abra o projeto no ambiente de desenvolvimento de sua escolha (Visual Studio, Visual Studio Code, etc.).
3. Execute os testes utilizando o runner de testes integrado ou através da linha de comando, dependendo do seu ambiente de desenvolvimento.

Exemplo de comando para rodar os testes com dotnet CLI:

```bash
dotnet test
