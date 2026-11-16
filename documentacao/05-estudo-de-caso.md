# 5 ESTUDO DE CASO

## 5.1 Caracterização do cenário

O estudo de caso foi desenvolvido considerando a Instituição Alfa, uma instituição de ensino fictícia utilizada como cenário para a aplicação dos conceitos de Gestão e Qualidade de Software.

Nesse contexto, a instituição recebe solicitações acadêmicas de estudantes relacionadas a diferentes necessidades, como questões financeiras, informações acadêmicas e outros assuntos administrativos. Para atender a essas demandas, é necessário manter as informações organizadas e permitir o acompanhamento de cada solicitação.

## 5.2 Problema identificado

A ausência de um sistema centralizado para o gerenciamento das solicitações pode dificultar o registro, a localização e o acompanhamento das demandas dos estudantes.

Entre as dificuldades consideradas no cenário estão:

- Falta de centralização das informações das solicitações.
- Dificuldade para identificar cada atendimento.
- Necessidade de consultar o andamento das demandas.
- Dificuldade para acompanhar o volume de solicitações.
- Necessidade de manter as informações atualizadas.

Diante desse cenário, identificou-se a necessidade de propor uma ferramenta que auxilie na organização e no acompanhamento das solicitações acadêmicas.

## 5.3 Solução proposta

Como solução para o problema apresentado, foi desenvolvido o TextQualid2, uma adaptação do sistema TextQualid, com o objetivo de demonstrar o gerenciamento de solicitações acadêmicas e a aplicação prática de testes automatizados no ecossistema .NET.

A aplicação permite que o estudante registre uma solicitação por meio de um formulário, informe seus dados e descreva sua necessidade. Após o cadastro, o sistema gera um protocolo de identificação, utilizado para localizar e consultar a solicitação.

A equipe responsável pode acessar um painel administrativo, visualizar as solicitações cadastradas, consultar seus detalhes e atualizar o status do atendimento, além de registrar observações.

Além das funcionalidades do sistema, foram desenvolvidos dois projetos de testes automatizados, utilizando NUnit e xUnit.net, para verificar operações do serviço responsável pelo gerenciamento das solicitações.

## 5.4 Funcionamento do sistema

O funcionamento do TextQualid2 está organizado em etapas:

**a) Cadastro da solicitação:** o estudante preenche o formulário com informações como nome, matrícula, e-mail, categoria, assunto e descrição.

**b) Geração do protocolo:** após o registro, o sistema gera um protocolo de identificação para a solicitação.

**c) Consulta da solicitação:** o estudante utiliza o protocolo para consultar as informações e verificar o status da demanda.

**d) Gerenciamento administrativo:** a equipe responsável acessa o painel administrativo, que apresenta as solicitações cadastradas e seus respectivos status.

**e) Visualização dos detalhes:** o sistema disponibiliza uma página com as informações completas de cada solicitação.

**f) Atualização do atendimento:** na página de detalhes, é possível modificar o status da solicitação e registrar observações.

## 5.5 Arquitetura e tecnologias utilizadas

O TextQualid2 foi desenvolvido com uma arquitetura dividida em frontend, backend e camada de persistência de dados.

O frontend é responsável pela interface de interação com os usuários, enquanto o backend processa as solicitações e disponibiliza os serviços por meio de uma API REST. A persistência das informações é realizada em um banco de dados SQLite.

As principais tecnologias utilizadas são:

- **C#:** linguagem de programação utilizada na implementação do backend e dos serviços do sistema.
- **ASP.NET Core:** framework utilizado para desenvolver a API REST.
- **Entity Framework Core:** tecnologia utilizada para realizar o mapeamento objeto-relacional e facilitar o acesso ao banco de dados.
- **SQLite:** banco de dados utilizado para armazenar as solicitações de maneira persistente.
- **HTML5:** utilizado na estruturação das páginas do frontend.
- **CSS3:** utilizado na estilização das interfaces.
- **JavaScript:** utilizado nas funcionalidades do frontend e na comunicação com a API.
- **NUnit:** framework utilizado para implementar e executar testes automatizados.
- **xUnit.net:** framework utilizado em um segundo projeto de testes para verificar operações equivalentes às testadas com NUnit.
- **Git e GitHub:** ferramentas utilizadas para controle de versão e gerenciamento do código-fonte, quando aplicáveis ao fluxo de desenvolvimento.

## 5.6 Aplicação dos testes automatizados

Para avaliar o comportamento das principais operações do sistema, foram criados dois projetos de testes independentes: TextQualid2.Tests.NUnit e TextQualid2.Tests.XUnit.

Cada projeto contém três testes automatizados relacionados às seguintes operações:

- **Cadastro de solicitação:** verifica se o registro é realizado corretamente, se o identificador e o protocolo são gerados e se o status inicial é definido como Aberta.
- **Busca por identificador:** verifica se uma solicitação cadastrada pode ser localizada e se as informações esperadas são retornadas.
- **Atualização de status:** verifica se o status e as observações da solicitação são atualizados corretamente.

Os testes utilizam um banco de dados SQLite em memória, preparado individualmente para cada execução. Essa configuração permite verificar as operações do serviço sem modificar os dados armazenados pela aplicação principal.

## 5.7 Resultados obtidos com a solução

A implementação do TextQualid2 resultou em uma aplicação funcional para o cadastro, a consulta e o gerenciamento de solicitações acadêmicas, com persistência dos dados em SQLite.

Na avaliação automatizada, foram executados três testes com NUnit e três com xUnit.net. Todos os seis testes foram aprovados, sem falhas ou testes ignorados.

Os resultados demonstram que as operações verificadas apresentaram o comportamento esperado durante as execuções realizadas, permitindo observar na prática a utilização dos dois frameworks de automação de testes.

Por se tratar de um projeto acadêmico, o sistema demonstra as funcionalidades essenciais da proposta e não representa uma solução institucional pronta para implantação em ambiente de produção.