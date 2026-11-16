
const formulario = document.getElementById("formConsulta");
const resultado = document.getElementById("resultadoSolicitacao");

formulario.addEventListener("submit", async function (event) {

    event.preventDefault();

    const protocolo = document.getElementById("protocolo").value.trim();

    resultado.textContent = "Consultando solicitação...";
    resultado.style.whiteSpace = "pre-line";

    try {

        const resposta = await fetch(
            `http://localhost:5020/solicitacoes/protocolo/${encodeURIComponent(protocolo)}`
        );

        const dados = await resposta.text();

        if (!resposta.ok) {
            throw new Error("Erro ao consultar solicitação.");
        }

        if (!dados.trim()) {
            resultado.textContent = "Nenhuma solicitação encontrada com esse protocolo.";
            return;
        }

        const solicitacao = JSON.parse(dados);

        resultado.textContent =
            "SOLICITAÇÃO ENCONTRADA!\n\n" +
            "Protocolo: " + solicitacao.protocolo + "\n" +
            "Nome: " + solicitacao.nome + "\n" +
            "Categoria: " + solicitacao.categoria + "\n" +
            "Assunto: " + solicitacao.assunto + "\n" +
            "Descrição: " + solicitacao.descricao + "\n" +
            "Status: " + solicitacao.status + "\n" +
            "Observações: " + (solicitacao.observacoes || "Nenhuma observação.");

    } catch (erro) {

        resultado.textContent =
            "Não foi possível realizar a consulta. Verifique se o sistema está funcionando.";

        console.error(erro);
    }

});
