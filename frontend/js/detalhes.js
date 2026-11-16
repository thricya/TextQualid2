
// Pega o ID da solicitação que veio pela URL
const parametros = new URLSearchParams(window.location.search);
const id = parametros.get("id");

// Busca os dados da solicitação no backend
async function carregarDetalhes() {

    if (!id) {
        alert("Nenhuma solicitação foi selecionada.");
        return;
    }

    try {

        const resposta = await fetch(
            `http://localhost:5020/solicitacoes/${id}`
        );

        if (!resposta.ok) {
            throw new Error("Solicitação não encontrada.");
        }

        const solicitacao = await resposta.json();

        // Preenche os campos com os dados recebidos
        document.getElementById("protocolo").textContent = solicitacao.protocolo;
        document.getElementById("nome").textContent = solicitacao.nome;
        document.getElementById("matricula").textContent = solicitacao.matricula;
        document.getElementById("email").textContent = solicitacao.email;
        document.getElementById("categoria").textContent = solicitacao.categoria;
        document.getElementById("assunto").textContent = solicitacao.assunto;
        document.getElementById("descricao").textContent = solicitacao.descricao;

        // Preenche os campos de atualização
        document.getElementById("status").value = solicitacao.status;
        document.getElementById("observacao").value =
            solicitacao.observacoes || "";

    } catch (erro) {

        alert("Não foi possível carregar os detalhes da solicitação.");
        console.error(erro);

    }
}

// Executa a busca ao abrir a página
carregarDetalhes();

// Atualiza o status da solicitação
const formularioStatus = document.getElementById("formStatus");

formularioStatus.addEventListener("submit", async function(event) {

    event.preventDefault();

    const dadosAtualizacao = {
        status: document.getElementById("status").value,
        observacoes: document.getElementById("observacao").value
    };

    try {

        const resposta = await fetch(
            `http://localhost:5020/solicitacoes/${id}/status`,
            {
                method: "PUT",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(dadosAtualizacao)
            }
        );

        if (!resposta.ok) {
            throw new Error("Não foi possível atualizar a solicitação.");
        }

        alert("Solicitação atualizada com sucesso!");

        // Atualiza os dados exibidos na página
        carregarDetalhes();

    } catch (erro) {

        alert("Erro ao atualizar a solicitação.");
        console.error(erro);

    }

});
