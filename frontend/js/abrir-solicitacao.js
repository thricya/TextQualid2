
const formulario = document.getElementById("formSolicitacao");

formulario.addEventListener("submit", async function(event) {

    event.preventDefault();

    const solicitacao = {
        nome: document.getElementById("nome").value,
        matricula: document.getElementById("matricula").value,
        email: document.getElementById("email").value,
        categoria: document.getElementById("categoria").value,
        assunto: document.getElementById("assunto").value,
        descricao: document.getElementById("descricao").value
    };

    try {

        const resposta = await fetch("http://localhost:5020/solicitacoes", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(solicitacao)
        });

        if (!resposta.ok) {
            throw new Error("Não foi possível cadastrar a solicitação.");
        }

        const resultado = await resposta.json();

        alert(
            "Solicitação cadastrada com sucesso!\n\n" +
            "Protocolo: " + resultado.protocolo +
            "\nStatus: " + resultado.status
        );

        formulario.reset();

    } catch (erro) {

        alert("Erro ao enviar solicitação. Verifique se o sistema está funcionando.");

        console.error(erro);
    }

});
