# 7 PLANO DE TESTES

## 7.1 Objetivo dos Testes

O plano de testes tem como objetivo verificar se as principais operações do sistema TextQualid2 apresentam o comportamento esperado, considerando os requisitos definidos para o projeto.

A estratégia adotada utiliza testes automatizados para avaliar as operações do serviço responsável pelo gerenciamento das solicitações acadêmicas. Para isso, foram utilizados os frameworks NUnit e xUnit.net, permitindo comparar suas estruturas e formas de implementação no ecossistema .NET.

## 7.2 Tipos de Testes

Foram considerados os seguintes tipos de verificações:

- **Testes automatizados de serviço:** verificam o comportamento das operações implementadas na classe SolicitacaoService.
- **Verificação de cadastro:** avalia se uma solicitação é cadastrada corretamente, recebendo identificador, protocolo e status inicial.
- **Verificação de consulta:** avalia se uma solicitação cadastrada pode ser localizada por meio de seu identificador.
- **Verificação de atualização:** avalia se o status e as observações de uma solicitação são atualizados corretamente.

Os testes automatizados foram implementados em dois projetos independentes, um utilizando NUnit e outro utilizando xUnit.net. Os dois projetos verificam operações equivalentes.

## 7.3 Ambiente de Testes

Os testes foram realizados em ambiente local, utilizando as seguintes tecnologias e ferramentas:

- Sistema operacional: Windows.
- Linguagem de programação: C#.
- Plataforma de desenvolvimento: .NET 10.
- Backend: ASP.NET Core.
- Banco de dados da aplicação: SQLite.
- Persistência de dados: Entity Framework Core.
- Banco de dados utilizado nos testes: SQLite em memória.
- Framework de testes 1: NUnit.
- Framework de testes 2: xUnit.net.
- Ferramenta de execução: comando `dotnet test`.
- Ambiente de desenvolvimento: Visual Studio Code e PowerShell.

O banco de dados SQLite em memória foi configurado individualmente para cada execução de teste, permitindo realizar as verificações sem alterar os dados persistidos pela aplicação principal.

## 7.4 Casos de Teste

Foram implementados três casos de teste para verificar as principais operações do serviço de solicitações.

| Código | Caso de teste | Resultado esperado |
|---|---|---|
| CT01 | Cadastrar uma nova solicitação. | O sistema deve gerar um identificador, criar um protocolo não vazio e definir o status inicial como Aberta. |
| CT02 | Buscar uma solicitação cadastrada por seu identificador. | O sistema deve retornar a solicitação correspondente e apresentar o nome esperado. |
| CT03 | Atualizar o status de uma solicitação. | O sistema deve atualizar o status para Em andamento e registrar corretamente as observações informadas. |

Os três casos foram implementados nos dois frameworks, conforme apresentado a seguir:

| Caso | NUnit | xUnit.net |
|---|---|---|
| CT01 — Cadastro | Aprovado | Aprovado |
| CT02 — Busca por identificador | Aprovado | Aprovado |
| CT03 — Atualização de status | Aprovado | Aprovado |

## 7.5 Preparação e Execução dos Testes

No projeto NUnit, a preparação do ambiente de teste é realizada pelo atributo `[SetUp]`, enquanto a liberação dos recursos ocorre por meio do atributo `[TearDown]`.

No projeto xUnit.net, a preparação é realizada pelo construtor da classe de teste, enquanto a liberação dos recursos é realizada pelo método `Dispose()`.

Os testes são executados separadamente por meio dos seguintes comandos:

**Execução dos testes NUnit:**

```powershell
dotnet test .\testes\TextQualid2.Tests.NUnit\TextQualid2.Tests.NUnit.csproj
```

**Execução dos testes xUnit.net:**

```powershell
dotnet test .\testes\TextQualid2.Tests.XUnit\TextQualid2.Tests.XUnit.csproj
```

A ferramenta de execução do .NET apresenta o resultado de cada teste, indicando a quantidade de testes aprovados, reprovados ou ignorados.

## 7.6 Critérios de Aprovação

Um caso de teste é considerado aprovado quando o comportamento observado corresponde ao resultado esperado definido para a operação.

Os resultados são classificados em:

- **Aprovado:** quando o comportamento observado corresponde ao resultado esperado.
- **Reprovado:** quando o sistema apresenta um comportamento diferente do esperado.
- **Não executado:** quando o teste ainda não foi realizado.

Para a avaliação dos frameworks, também são considerados a organização dos testes, os recursos utilizados na preparação e finalização do ambiente e a facilidade de execução.

## 7.7 Considerações sobre o Plano de Testes

O plano de testes foi elaborado para avaliar as operações principais do serviço de solicitações do TextQualid2. A utilização de NUnit e xUnit.net em projetos separados permite observar como cada framework organiza e executa os testes automatizados.

Além dos testes automatizados, foram realizadas verificações manuais da aplicação no navegador, contemplando o cadastro de solicitações, a consulta por protocolo, a visualização dos detalhes e a atualização de status.

Essa combinação permite avaliar tanto as operações internas do serviço quanto o funcionamento das principais funcionalidades disponibilizadas na interface da aplicação.