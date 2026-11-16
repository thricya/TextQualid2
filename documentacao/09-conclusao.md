# 9 CONCLUSÃO

O desenvolvimento do TextQualid2 possibilitou aplicar, na prática, conceitos relacionados à Gestão e à Qualidade de Software, desde a definição dos requisitos até a implementação, validação e execução dos testes das funcionalidades do sistema.

O projeto teve como objetivo desenvolver um protótipo para organizar o gerenciamento de solicitações acadêmicas da Instituição Alfa, permitindo que os estudantes realizem solicitações, recebam protocolos e acompanhem o andamento de seus registros. Para os funcionários, o sistema disponibiliza um painel administrativo que permite visualizar as solicitações, consultar seus detalhes e atualizar seus status e observações.

Durante o desenvolvimento, foram utilizadas tecnologias como C#, ASP.NET Core, HTML5, CSS3, JavaScript, SQLite e Entity Framework Core. A integração entre frontend e backend possibilitou o funcionamento das operações de cadastro, consulta, atualização e armazenamento das informações.

A aplicação dos conceitos de Garantia da Qualidade (QA) e Controle da Qualidade (QC) contribuiu para compreender a importância de organizar o processo de desenvolvimento e verificar o comportamento do produto. Além disso, a implementação dos testes automatizados permitiu comparar dois frameworks utilizados no ecossistema .NET: NUnit e xUnit.net.

Foram desenvolvidos três casos de teste para cada framework, totalizando seis execuções de testes automatizados. Todos foram aprovados, sem falhas ou testes ignorados, alcançando um percentual de aprovação de 100% nos cenários avaliados. Essa experiência demonstrou que ambos os frameworks atenderam às necessidades de automação definidas para o projeto.

A comparação também permitiu observar diferenças na estrutura e na organização dos testes. Enquanto o NUnit utiliza recursos como `[SetUp]`, `[TearDown]` e `[Test]`, o xUnit.net utiliza construtores, `Dispose()` e `[Fact]`. Os dois apresentaram resultados satisfatórios na execução dos cenários propostos.

Apesar dos resultados alcançados, o TextQualid2 ainda apresenta possibilidades de evolução, como a implementação de autenticação de usuários, controle de acesso por perfil, notificações automáticas, testes de integração da API e avaliações mais abrangentes de segurança, desempenho e usabilidade.

Conclui-se que o TextQualid2 atingiu seu objetivo acadêmico ao apresentar um protótipo funcional para o gerenciamento de solicitações acadêmicas e demonstrar a importância da aplicação de práticas de qualidade e automação de testes durante o desenvolvimento de software. A experiência também proporcionou aos integrantes do grupo a oportunidade de ampliar seus conhecimentos técnicos, trabalhar com tecnologias do ecossistema .NET e aplicar, na prática, os conceitos estudados ao longo da disciplina.