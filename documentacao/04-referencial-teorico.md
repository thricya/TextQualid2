# 4 FUNDAMENTAÇÃO TEÓRICA

## 4.1 Qualidade de Software

A qualidade de software está relacionada à capacidade de um sistema atender aos requisitos estabelecidos e às necessidades de seus usuários. Para que um produto de software seja considerado adequado, é importante que suas funcionalidades apresentem resultados corretos, que as informações sejam tratadas de maneira consistente e que o sistema cumpra os objetivos para os quais foi desenvolvido.

A norma ISO/IEC 25010:2023 apresenta um modelo de qualidade de produto de software composto por características que auxiliam na especificação, medição e avaliação da qualidade. Esse modelo oferece critérios que podem ser considerados durante diferentes etapas do ciclo de vida do software.

No desenvolvimento do TextQualid2, a qualidade está relacionada principalmente ao funcionamento das funcionalidades de cadastro, consulta por protocolo, visualização das solicitações e atualização de status. Essas funcionalidades precisam apresentar resultados coerentes com as informações registradas no sistema.

## 4.2 Garantia da Qualidade de Software (QA)

A Garantia da Qualidade de Software, conhecida pela sigla QA (Quality Assurance), corresponde ao conjunto de atividades planejadas e sistemáticas que buscam assegurar que os processos de desenvolvimento sigam critérios e padrões de qualidade.

A garantia da qualidade possui caráter preventivo, pois procura reduzir a possibilidade de problemas durante o planejamento e o desenvolvimento. Entre as atividades relacionadas ao QA estão a definição de requisitos, o estabelecimento de padrões, a documentação, as revisões e o planejamento dos testes.

No projeto TextQualid2, a aplicação de QA está relacionada à organização dos requisitos, à definição das funcionalidades esperadas, à estruturação do projeto e à elaboração do plano de testes. Essas atividades ajudam a orientar o desenvolvimento e a manter o sistema alinhado aos objetivos estabelecidos.

## 4.3 Controle da Qualidade de Software (QC)

O Controle da Qualidade de Software, conhecido como QC (Quality Control), está relacionado às atividades de verificação do produto desenvolvido, com o objetivo de identificar falhas e avaliar se o sistema atende aos requisitos definidos.

Diferentemente da garantia da qualidade, que atua principalmente sobre os processos, o controle da qualidade concentra-se na avaliação do produto. Entre suas atividades estão a execução de testes, a verificação dos resultados, a identificação de comportamentos incorretos e a análise das funcionalidades implementadas.

No TextQualid2, o QC foi aplicado por meio da execução de testes automatizados sobre as operações do serviço de solicitações. Foram verificadas as operações de cadastro, busca de solicitações por identificador e atualização de status e observações. Os resultados permitiram verificar se o comportamento implementado correspondia ao esperado.

## 4.4 Testes de Software

Os testes de software são atividades utilizadas para verificar o comportamento de um sistema e identificar possíveis falhas. Eles permitem comparar os resultados obtidos com os resultados esperados, contribuindo para a avaliação da qualidade do produto.

Segundo Pressman e Maxim (2020), os testes fazem parte das atividades de engenharia de software e são importantes para avaliar se os componentes e as funcionalidades implementadas atendem aos requisitos estabelecidos.

Os testes automatizados são executados por meio de códigos e ferramentas específicas, permitindo repetir verificações de maneira padronizada. Essa prática facilita a identificação de problemas após alterações no código e contribui para a manutenção do sistema.

No desenvolvimento do TextQualid2, foram implementados testes automatizados para verificar três operações principais do serviço de solicitações:

- Cadastro de uma solicitação, verificando a geração do identificador, do protocolo e a definição do status inicial como Aberta.
- Busca de uma solicitação cadastrada por meio de seu identificador, verificando se os dados esperados são retornados.
- Atualização do status de uma solicitação, verificando também o registro das observações correspondentes.

Para executar esses testes, foi utilizado um banco de dados SQLite em memória, configurado separadamente em cada execução de teste. Essa abordagem permite realizar as verificações sem utilizar os dados persistidos pela aplicação principal.

## 4.5 Automação de Testes de Software

A automação de testes consiste na utilização de ferramentas e códigos para executar verificações de forma automática, reduzindo a necessidade de repetição manual de procedimentos. Essa prática permite padronizar a execução dos testes, verificar resultados e facilitar a identificação de falhas durante o desenvolvimento.

Os frameworks de automação de testes oferecem estruturas, recursos e métodos de verificação que auxiliam os desenvolvedores na criação e execução dos testes. No ecossistema .NET, existem diferentes opções, entre elas NUnit e xUnit.net.

A utilização de frameworks de testes permite organizar os cenários de verificação, definir condições iniciais, executar métodos de teste e comparar os resultados obtidos com os valores esperados.

No TextQualid2, foram utilizados dois projetos de teste separados, um com NUnit e outro com xUnit.net. Ambos verificam operações equivalentes do serviço de solicitações, permitindo comparar suas estruturas e formas de implementação.

## 4.6 Framework NUnit

O NUnit é um framework de testes de código aberto utilizado no ecossistema .NET. Ele oferece recursos para organizar, executar e verificar testes automatizados, sendo utilizado principalmente em projetos desenvolvidos com C#.

Entre seus principais recursos estão os atributos `[Test]`, utilizados para identificar métodos de teste; `[SetUp]`, utilizado para preparar o ambiente antes de cada teste; e `[TearDown]`, utilizado para executar procedimentos de finalização após cada teste. O framework também disponibiliza métodos de asserção para comparar resultados e verificar condições esperadas.

No projeto TextQualid2, o NUnit foi utilizado para implementar três testes automatizados. A preparação do ambiente foi realizada por meio do atributo `[SetUp]`, enquanto a liberação dos recursos utilizados ocorreu por meio de `[TearDown]`.

## 4.7 Framework xUnit.net

O xUnit.net é um framework de testes de código aberto utilizado para a criação e execução de testes automatizados em aplicações .NET. Ele apresenta uma estrutura própria para organizar os métodos de teste e preparar os recursos necessários para sua execução.

Entre seus principais recursos estão o atributo `[Fact]`, utilizado para identificar um método de teste, e `[Theory]`, que permite executar um mesmo teste com diferentes conjuntos de dados. Para preparar o ambiente, o framework utiliza o construtor da classe de teste e, quando necessário, a interface `IDisposable` para liberar recursos após a execução.

No projeto TextQualid2, o xUnit.net foi utilizado para implementar três testes automatizados equivalentes aos desenvolvidos com NUnit. A preparação do ambiente ocorreu no construtor da classe de teste, enquanto a liberação dos recursos foi realizada pelo método `Dispose()`.

## 4.8 Gestão da Qualidade em Projetos de Software

A gestão da qualidade em projetos de software envolve o planejamento, a organização, o acompanhamento e a avaliação das atividades necessárias para que o produto desenvolvido atenda aos objetivos estabelecidos.

Pressman e Maxim (2020) apresentam a qualidade como parte integrante da engenharia de software, envolvendo práticas que acompanham o desenvolvimento e contribuem para a construção de produtos adequados aos requisitos definidos.

No contexto do TextQualid2, a gestão da qualidade foi considerada desde a definição da proposta do sistema até a implementação e a realização dos testes automatizados. A organização das atividades, a documentação dos requisitos, a divisão das responsabilidades e o registro dos resultados contribuem para acompanhar o desenvolvimento do projeto.

Dessa maneira, a aplicação dos conceitos de qualidade de software permite avaliar não apenas se o sistema funciona, mas também se as funcionalidades desenvolvidas correspondem às necessidades identificadas para o cenário da Instituição Alfa e se os testes automatizados contribuem para verificar seu comportamento.