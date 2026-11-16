# 1 INTRODUÇÃO

A qualidade de software é um aspecto fundamental no desenvolvimento de sistemas, pois está relacionada à capacidade de um produto atender às necessidades dos usuários, funcionar corretamente e apresentar resultados confiáveis. Nesse contexto, a realização de testes é uma etapa importante para identificar falhas, verificar o comportamento das funcionalidades e contribuir para a melhoria contínua do software.

Em instituições de ensino, o atendimento às solicitações acadêmicas dos estudantes exige organização, acompanhamento e controle das informações. Quando esses processos são realizados de maneira pouco estruturada, podem ocorrer dificuldades na localização de solicitações, no acompanhamento dos atendimentos e na comunicação sobre o andamento das demandas.

Diante dessa situação, este trabalho apresenta o **TextQualid2**, uma adaptação do sistema de gerenciamento de solicitações acadêmicas TextQualid, proposto para a Instituição Alfa, uma instituição fictícia utilizada como cenário para o estudo de caso. A solução permite que os estudantes registrem solicitações, recebam um protocolo de identificação e acompanhem o andamento de suas demandas. Também disponibiliza um painel administrativo para consulta das solicitações cadastradas, visualização de detalhes e atualização de status e observações.

O desenvolvimento do TextQualid2 utiliza C# e ASP.NET Core na construção do backend, com uma API REST responsável pelo processamento das solicitações. O frontend foi desenvolvido com HTML5, CSS3 e JavaScript. Para o armazenamento e gerenciamento dos dados, foram utilizados o banco de dados SQLite e o Entity Framework Core.

Além do desenvolvimento do sistema, este trabalho tem como foco a aplicação prática de testes automatizados no ecossistema .NET, utilizando os frameworks **NUnit e xUnit.net**. Foram implementados testes para verificar funcionalidades do serviço de solicitações, como o cadastro, a busca por identificador e a atualização de status. Os dois frameworks foram utilizados em projetos de teste separados, permitindo observar suas estruturas, recursos e formas de execução.

A execução dos testes utiliza um banco de dados SQLite em memória, permitindo realizar as verificações sem interferir nos dados persistidos pela aplicação. Ao todo, foram implementados seis testes automatizados, sendo três com NUnit e três com xUnit.net, todos aprovados durante a execução.

Assim, o projeto busca demonstrar a importância da qualidade de software por meio do desenvolvimento de uma aplicação funcional e da utilização de ferramentas de automação de testes, possibilitando comparar as características dos frameworks NUnit e xUnit.net e compreender sua contribuição para a confiabilidade e manutenção de aplicações desenvolvidas com .NET.