# 8 RESULTADOS DOS TESTES

## 8.1 Execução dos Testes

Após a implementação das principais funcionalidades do TextQualid2, foram realizados testes para verificar o comportamento dos serviços responsáveis pelo cadastro, consulta e atualização das solicitações acadêmicas.

A avaliação da automação foi realizada utilizando dois frameworks de testes para aplicações .NET: NUnit e xUnit.net. Para cada framework, foram implementados três casos de teste equivalentes, utilizando banco de dados SQLite em memória e Entity Framework Core.

Além dos testes automatizados, também foram realizadas verificações manuais no navegador para observar o funcionamento das principais funcionalidades do sistema e a comunicação entre frontend e backend.

## 8.2 Resultados Obtidos

Os testes automatizados avaliaram três operações principais do sistema:

| Código | Teste realizado | Resultado esperado | Situação |
|---|---|---|---|
| CT01 | Cadastro de uma solicitação. | A solicitação deve ser cadastrada, receber um identificador, gerar um protocolo e iniciar com o status Aberta. | Aprovado |
| CT02 | Busca de uma solicitação pelo identificador. | O serviço deve retornar a solicitação cadastrada com os dados esperados. | Aprovado |
| CT03 | Atualização do status da solicitação. | O sistema deve atualizar o status para Em andamento e salvar as observações informadas. | Aprovado |

Os três casos foram executados nos dois frameworks, totalizando seis execuções de testes automatizados.

## 8.3 Comparação dos Resultados dos Frameworks

Os resultados obtidos na execução dos projetos de teste foram:

| Framework | Total de testes | Aprovados | Reprovados | Ignorados |
|---|---:|---:|---:|---:|
| NUnit | 3 | 3 | 0 | 0 |
| xUnit.net | 3 | 3 | 0 | 0 |
| **Total** | **6** | **6** | **0** | **0** |

Os resultados demonstram que os dois frameworks conseguiram executar corretamente os cenários propostos, sem apresentar falhas ou testes ignorados.

## 8.4 Análise dos Resultados

Com base nos resultados, foi possível verificar que os serviços responsáveis pelas principais operações avaliadas apresentaram os comportamentos esperados.

No teste de cadastro, o sistema criou uma solicitação, gerou um protocolo e atribuiu o status inicial Aberta. No teste de consulta, foi possível recuperar uma solicitação cadastrada por meio de seu identificador. Já no teste de atualização, o serviço alterou o status da solicitação para Em andamento e registrou as observações informadas.

A execução dos mesmos cenários nos dois frameworks permitiu observar que tanto NUnit quanto xUnit.net atenderam às necessidades de automação de testes do projeto.

Também foram realizadas verificações manuais no navegador, nas quais foram observados o cadastro de solicitações, a consulta por protocolo, a apresentação das solicitações no painel administrativo, a visualização dos detalhes e a atualização de status e observações.

Essas verificações manuais complementaram os testes automatizados, mas não fazem parte da contagem dos seis testes executados pelos frameworks.

## 8.5 Indicadores dos Testes

Considerando os resultados dos testes automatizados, foram obtidos os seguintes indicadores:

- Total de testes executados: 6.
- Testes aprovados: 6.
- Testes reprovados: 0.
- Testes ignorados: 0.
- Percentual de aprovação: 100%.

O percentual de aprovação foi calculado dividindo a quantidade de testes aprovados pelo total de testes executados e multiplicando o resultado por 100.

**Cálculo:**

(6 ÷ 6) × 100 = 100%

Os resultados indicam que todos os cenários automatizados implementados foram aprovados durante as execuções realizadas.

## 8.6 Limitações Identificadas

Apesar dos resultados positivos, o TextQualid2 apresenta limitações por se tratar de um protótipo acadêmico.

Os testes automatizados implementados verificam operações da camada de serviços, utilizando SQLite em memória. Portanto, eles não representam uma cobertura completa de todas as funcionalidades do sistema e não substituem testes de integração HTTP, interface, segurança ou desempenho.

Entre os pontos que poderão ser aprimorados em versões futuras, destacam-se:

- Implementação de autenticação de usuários.
- Controle de acesso para estudantes e funcionários.
- Ampliação das validações no backend.
- Implementação de notificações automáticas.
- Criação de testes automatizados para os endpoints da API.
- Ampliação dos testes de segurança, desempenho e usabilidade.

## 8.7 Considerações Finais dos Resultados

Os resultados demonstram que os seis testes automatizados implementados foram aprovados, sendo três executados com NUnit e três com xUnit.net.

A comparação prática permitiu verificar que os dois frameworks são capazes de atender às necessidades de automação dos cenários propostos para o TextQualid2.

As verificações manuais também contribuíram para avaliar o funcionamento geral da aplicação, incluindo a comunicação entre frontend e backend e a persistência das informações.

Dessa forma, os resultados alcançados contribuíram para avaliar as funcionalidades implementadas, compreender a utilização dos frameworks de testes e identificar possibilidades de melhoria para futuras versões do sistema.