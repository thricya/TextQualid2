
async function carregarSolicitacoes() {

    const tabela = document.getElementById("listaSolicitacoes");

    try {

        const resposta = await fetch("http://localhost:5020/solicitacoes");

        if (!resposta.ok) {
            throw new Error("Erro ao buscar solicitações.");
        }

        const solicitacoes = await resposta.json();

        // Atualiza os números dos cards
        document.getElementById("totalSolicitacoes").textContent =
            solicitacoes.length;

        document.getElementById("solicitacoesAbertas").textContent =
            solicitacoes.filter(s => s.status === "Aberta").length;

        document.getElementById("solicitacoesAndamento").textContent =
            solicitacoes.filter(s => s.status === "Em andamento").length;

        document.getElementById("solicitacoesConcluidas").textContent =
            solicitacoes.filter(s => s.status === "Concluída").length;

        // Limpa a tabela antes de preenchê-la
        tabela.innerHTML = "";

        if (solicitacoes.length === 0) {
            tabela.innerHTML = `
                <tr>
                    <td colspan="6">Nenhuma solicitação cadastrada.</td>
                </tr>
            `;
            return;
        }

        // Cria uma linha para cada solicitação
        solicitacoes.forEach(solicitacao => {

            const linha = document.createElement("tr");

            let classeStatus = "aberto";

            if (solicitacao.status === "Em andamento") {
                classeStatus = "andamento";
            } else if (solicitacao.status === "Concluída") {
                classeStatus = "concluido";
            }

            const dados = [
                solicitacao.protocolo,
                solicitacao.nome,
                solicitacao.categoria,
                solicitacao.assunto
            ];

            dados.forEach(valor => {
                const coluna = document.createElement("td");
                coluna.textContent = valor || "";
                linha.appendChild(coluna);
            });

            const colunaStatus = document.createElement("td");
            const etiqueta = document.createElement("span");

            etiqueta.className = "status " + classeStatus;
            etiqueta.textContent = solicitacao.status;

            colunaStatus.appendChild(etiqueta);
            linha.appendChild(colunaStatus);

            const colunaAcao = document.createElement("td");
            const link = document.createElement("a");

            link.href = "detalhes.html?id=" + solicitacao.id;
            link.className = "link-detalhes";
            link.textContent = "Visualizar";

            colunaAcao.appendChild(link);
            linha.appendChild(colunaAcao);

            tabela.appendChild(linha);

        });

    } catch (erro) {

        console.error(erro);

        tabela.innerHTML = `
            <tr>
                <td colspan="6">
                    Não foi possível carregar as solicitações.
                </td>
            </tr>
        `;
    }
}

carregarSolicitacoes();
