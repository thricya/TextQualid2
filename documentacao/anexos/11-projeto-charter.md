# 11 APÊNDICE A — PROJECT CHARTER (TERMO DE ABERTURA DO PROJETO)

## A.1 Identificação do Projeto

**Nome do projeto:** TextQualid2 — Sistema de Gerenciamento de Solicitações Acadêmicas.

**Instituição:** Instituição Alfa (fictícia).

**Área:** Gestão e Qualidade de Software.

**Tipo de projeto:** Projeto acadêmico de desenvolvimento e avaliação da qualidade de software.

## A.2 Justificativa

O projeto TextQualid2 foi desenvolvido com a proposta de criar uma solução tecnológica para organizar o gerenciamento de solicitações acadêmicas. A aplicação busca centralizar os registros, facilitar a consulta por protocolo e permitir o acompanhamento do andamento das solicitações.

Além do desenvolvimento do sistema, o projeto contempla a aplicação de testes automatizados utilizando os frameworks NUnit e xUnit.net, possibilitando observar suas estruturas e comparar seus resultados em cenários equivalentes.

## A.3 Objetivo Geral

Desenvolver um protótipo de sistema web que permita cadastrar, consultar e acompanhar solicitações acadêmicas, possibilitando a atualização de seus status e observações por meio de um painel administrativo, além de aplicar e comparar testes automatizados com NUnit e xUnit.net.

## A.4 Objetivos Específicos

- Permitir o cadastro de solicitações acadêmicas.
- Gerar um protocolo para cada solicitação registrada.
- Possibilitar a consulta de solicitações por protocolo.
- Apresentar os detalhes das solicitações cadastradas.
- Permitir a atualização do status e o registro de observações.
- Disponibilizar um painel administrativo para visualização das solicitações.
- Utilizar banco de dados para armazenar as informações.
- Implementar testes automatizados para verificar operações dos serviços.
- Comparar os frameworks NUnit e xUnit.net.
- Aplicar conceitos de Garantia e Controle da Qualidade de Software.

## A.5 Escopo do Projeto

O escopo contempla o desenvolvimento de um protótipo web com funcionalidades de cadastro, consulta, acompanhamento e gerenciamento de solicitações acadêmicas.

A aplicação foi desenvolvida utilizando:

- **Frontend:** HTML5, CSS3 e JavaScript.
- **Backend:** C# com ASP.NET Core e .NET 10.
- **Banco de dados:** SQLite.
- **Mapeamento e persistência:** Entity Framework Core.
- **Testes automatizados:** NUnit e xUnit.net.

O projeto também contempla verificações manuais das funcionalidades da aplicação e testes automatizados da camada de serviços, utilizando SQLite em memória.

**Não fazem parte do escopo desta versão:**

- Autenticação e cadastro de usuários com senhas.
- Controle de acesso por perfil.
- Envio automático de notificações.
- Integração com sistemas acadêmicos externos.
- Implantação em ambiente de produção.
- Testes automatizados completos da interface e dos endpoints HTTP.

## A.6 Partes Interessadas

| Parte interessada | Participação |
|---|---|
| Integrantes do grupo | Planejamento, desenvolvimento, documentação e testes. |
| Professor da disciplina | Orientação e avaliação acadêmica. |
| Estudantes | Usuários previstos para realizar e acompanhar solicitações. |
| Funcionários | Usuários previstos para consultar e gerenciar solicitações. |
| Instituição Alfa | Instituição fictícia utilizada como cenário do projeto. |

## A.7 Equipe do Projeto

- Thricya Willane Silva — RA 1352524501.
- Victor Hugo Adorno — RA 12524245127.
- Carlos Daniel Batista — RA 722422327.
- Jamison Dias da Silva — RA 722522127.
- André Luiz Salgado — RA 1252211620339.
- Gabriel Felipe Amaral — RA 12825125501.
- Nicolas Mavridis Bedendo — RA 825231388.

## A.8 Recursos Necessários

- Computadores para desenvolvimento.
- Visual Studio Code.
- .NET 10 SDK.
- C# e ASP.NET Core.
- Entity Framework Core.
- SQLite.
- Navegador Google Chrome.
- Frameworks NUnit e xUnit.net.
- Git e GitHub para controle de versão, quando utilizados pela equipe.

## A.9 Riscos do Projeto

| Risco | Possível impacto |
|---|---|
| Dificuldades técnicas durante o desenvolvimento. | Atrasos na implementação. |
| Falhas na comunicação entre frontend e backend. | Funcionamento incorreto das funcionalidades. |
| Erros no armazenamento dos dados. | Perda ou inconsistência de informações. |
| Tempo limitado para desenvolvimento. | Redução do escopo planejado. |
| Ausência de autenticação. | Limitação de segurança do protótipo. |
| Falhas nos testes automatizados. | Dificuldade para verificar o comportamento dos serviços. |

## A.10 Critérios de Sucesso

O projeto será considerado academicamente concluído quando:

- As principais funcionalidades previstas estiverem implementadas.
- O cadastro e a consulta por protocolo funcionarem.
- A atualização dos status e das observações estiver disponível.
- Os dados permanecerem armazenados após a reinicialização do backend.
- Os testes automatizados com NUnit e xUnit.net forem executados e documentados.
- Os resultados dos dois frameworks forem apresentados e comparados.
- A documentação do projeto estiver organizada.

## A.11 Aprovação do Termo de Abertura

Este Termo de Abertura registra a proposta, os objetivos, o escopo, os recursos e os critérios de sucesso do projeto TextQualid2, servindo como referência para o desenvolvimento acadêmico.

**Projeto:** TextQualid2.

**Responsáveis:** Integrantes do grupo.

**Finalidade:** Desenvolvimento e avaliação acadêmica na disciplina de Gestão e Qualidade de Software.