# 6 REQUISITOS DO SISTEMA

Os requisitos de software descrevem as funcionalidades e as condições que o sistema deve atender para cumprir seus objetivos. No TextQualid2, os requisitos foram definidos considerando as necessidades do cenário proposto para a Instituição Alfa, as funcionalidades implementadas e a utilização de frameworks de testes automatizados.

## 6.1 Requisitos Funcionais (RF)

Os requisitos funcionais descrevem as operações que o sistema deve realizar.

| Código | Requisito funcional |
|---|---|
| RF01 | O sistema deve permitir o cadastro de solicitações acadêmicas por meio de um formulário. |
| RF02 | O sistema deve receber os dados do estudante, incluindo nome, matrícula e e-mail. |
| RF03 | O sistema deve permitir a seleção da categoria e o preenchimento do assunto e da descrição da solicitação. |
| RF04 | O sistema deve gerar um protocolo de identificação para cada solicitação cadastrada. |
| RF05 | O sistema deve iniciar uma nova solicitação com o status Aberta. |
| RF06 | O sistema deve permitir a consulta de uma solicitação por meio do protocolo. |
| RF07 | O sistema deve apresentar os dados da solicitação consultada. |
| RF08 | O sistema deve permitir a visualização das solicitações cadastradas em um painel administrativo. |
| RF09 | O sistema deve permitir a visualização dos detalhes de cada solicitação. |
| RF10 | O sistema deve permitir a atualização do status de uma solicitação. |
| RF11 | O sistema deve permitir o registro de observações durante a atualização de uma solicitação. |
| RF12 | O sistema deve armazenar as informações das solicitações no banco de dados. |

## 6.2 Requisitos Não Funcionais (RNF)

Os requisitos não funcionais descrevem características e condições relacionadas ao funcionamento e à implementação do sistema.

| Código | Requisito não funcional |
|---|---|
| RNF01 | O backend deve ser desenvolvido utilizando a linguagem C# e o framework ASP.NET Core. |
| RNF02 | O frontend deve utilizar HTML5, CSS3 e JavaScript. |
| RNF03 | A comunicação entre frontend e backend deve ocorrer por meio de uma API REST. |
| RNF04 | O sistema deve utilizar SQLite como banco de dados para armazenar as informações. |
| RNF05 | O acesso e o gerenciamento dos dados devem utilizar o Entity Framework Core. |
| RNF06 | As informações cadastradas devem permanecer armazenadas após a reinicialização do backend. |
| RNF07 | As páginas devem apresentar uma organização visual que facilite a utilização das funcionalidades disponíveis. |
| RNF08 | O código JavaScript das páginas deve ser organizado em arquivos externos, separados da estrutura HTML. |
| RNF09 | O projeto deve possuir documentação que descreva seus objetivos, requisitos, tecnologias e testes realizados. |
| RNF10 | O projeto deve utilizar os frameworks NUnit e xUnit.net para implementar e executar testes automatizados. |

## 6.3 Regras de Negócio (RN)

As regras de negócio estabelecem condições que orientam o funcionamento do sistema.

| Código | Regra de negócio |
|---|---|
| RN01 | Toda solicitação cadastrada deve receber um protocolo de identificação. |
| RN02 | Toda nova solicitação deve iniciar com o status Aberta. |
| RN03 | Os status disponibilizados na aplicação são Aberta, Em andamento e Concluída. |
| RN04 | A consulta pelo estudante deve utilizar o protocolo da solicitação. |
| RN05 | A equipe responsável pode atualizar o status e registrar observações da solicitação. |
| RN06 | Cada solicitação deve possuir um identificador próprio no banco de dados. |

## 6.4 Considerações sobre os requisitos

Os requisitos apresentados foram definidos com base nas funcionalidades desenvolvidas no TextQualid2. A documentação permite identificar as operações disponíveis e estabelecer critérios para verificar o comportamento do sistema durante os testes.

A implementação contempla o cadastro, a consulta, a visualização e a atualização das solicitações, além da persistência das informações em SQLite.

A avaliação da qualidade também contempla testes automatizados implementados em projetos separados, utilizando NUnit e xUnit.net. Cada framework possui três testes destinados à verificação de operações do serviço de solicitações.

Por se tratar de um projeto acadêmico, algumas funcionalidades que poderiam existir em uma solução institucional mais completa, como autenticação de usuários, controle de permissões e notificações automáticas, não fazem parte da implementação atual.