# TextQualid2

**Sistema de gerenciamento de solicitações acadêmicas**, desenvolvido como protótipo acadêmico para demonstrar o funcionamento de uma API em C# e a automação de testes com **NUnit** e **xUnit.net**.

## Objetivo

Permitir o registro e o acompanhamento de solicitações acadêmicas, com identificação por protocolo e atualização do andamento das demandas.

## Funcionalidades

- Cadastrar solicitações com dados do estudante e descrição da demanda.
- Gerar um protocolo e atribuir o status inicial **Aberta**.
- Consultar uma solicitação pelo protocolo.
- Listar solicitações em um painel com indicadores por status.
- Visualizar detalhes e atualizar o status e as observações.

Os status utilizados são **Aberta**, **Em andamento** e **Concluída**.

## Tecnologias

| Camada | Tecnologias |
|---|---|
| Frontend | HTML5, CSS3 e JavaScript |
| Backend | C#, .NET 10 e ASP.NET Core (API REST) |
| Persistência | SQLite e Entity Framework Core |
| Testes | NUnit e xUnit.net, com SQLite em memória |
| Versionamento | Git e GitHub |

## Estrutura do projeto

```text
TextQualid2/
├── backend/
│   ├── TextQualid2.Api/       # Endpoints HTTP e configuração da API
│   └── TextQualid2.Core/      # Modelo, contexto e serviço de solicitações
├── frontend/                 # Páginas HTML, CSS e JavaScript
├── testes/
│   ├── TextQualid2.Tests.NUnit/
│   └── TextQualid2.Tests.XUnit/
└── documentacao/             # Relatório e anexos em Markdown
```

## Pré-requisitos

- **SDK do .NET 10** instalado.
- Navegador web para abrir o frontend.
- Opcional: VS Code com extensão Live Server para servir as páginas HTML.

## Como executar a API

No PowerShell, a partir da pasta principal do projeto:

```powershell
cd .\backend\TextQualid2.Api
dotnet run --urls "http://localhost:5020"
```

A API estará disponível em `http://localhost:5020`. **Mantenha esse terminal aberto** enquanto utiliza o sistema.

Em seguida, abra `frontend/index.html` no navegador (preferencialmente por um servidor local, como o Live Server). O JavaScript do frontend utiliza `http://localhost:5020` para acessar a API.

> O banco de dados SQLite local é criado automaticamente pela API, caso ainda não exista. O arquivo `.db` não é versionado no Git.

## Endpoints da API

| Método | Rota | Finalidade |
|---|---|---|
| `POST` | `/solicitacoes` | Cadastrar solicitação |
| `GET` | `/solicitacoes` | Listar solicitações |
| `GET` | `/solicitacoes/protocolo/{protocolo}` | Consultar por protocolo |
| `GET` | `/solicitacoes/{id}` | Consultar por ID |
| `PUT` | `/solicitacoes/{id}/status` | Atualizar status e observações |

### Consultar solicitações pelo PowerShell

Com a API em execução, abra outro terminal e utilize:

```powershell
Invoke-RestMethod -Uri "http://localhost:5020/solicitacoes" -Method Get
```

## Testes automatizados

O projeto contém **três cenários de teste em cada framework**, totalizando seis execuções:

1. **Cadastro:** verifica a criação da solicitação, a geração do protocolo e o status inicial `Aberta`.
2. **Consulta por ID:** verifica a recuperação dos dados de uma solicitação cadastrada.
3. **Atualização:** verifica a mudança do status para `Em andamento` e o registro de observações.

Os testes exercitam a **camada de serviço**, utilizando **SQLite em memória** para isolamento dos dados. Eles **não** são testes automatizados da interface nem dos endpoints HTTP.

Execute os comandos abaixo **na pasta principal `TextQualid2`**:

**NUnit**

```powershell
dotnet test .\testes\TextQualid2.Tests.NUnit\TextQualid2.Tests.NUnit.csproj
```

**xUnit.net**

```powershell
dotnet test .\testes\TextQualid2.Tests.XUnit\TextQualid2.Tests.XUnit.csproj
```

Na execução documentada do projeto, os resultados foram **3/3 testes aprovados com NUnit** e **3/3 com xUnit.net**, sem falhas. Esses números são referentes àquela execução, não a uma verificação contínua.

## Documentação

Os arquivos do relatório acadêmico estão em [`documentacao/`](documentacao/), incluindo introdução, objetivos, justificativa, referencial teórico, estudo de caso, requisitos, plano de testes, resultados, conclusão, referências e anexos.

## Equipe

- Thricya Willane Silva
- Victor Hugo Adorno
- Carlos Daniel Batista
- Jamison Dias da Silva
- André Luiz Salgado
- Gabriel Felipe Amaral
- Nicolas Mavridis Bedendo

**Professor:** Hewerton Santiago.

---

*Projeto acadêmico e demonstrativo; não representa uma implantação em produção.*
