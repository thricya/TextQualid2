
using TextQualid2.Core.Models;
using TextQualid2.Core.Services;
using Microsoft.EntityFrameworkCore;
using TextQualid2.Core.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração da documentação da API
builder.Services.AddOpenApi();

// Disponibiliza o serviço de solicitações para a API
builder.Services.AddDbContext<TextQualid2Context>(options =>
    options.UseSqlite("Data Source=textqualid2.db"));

builder.Services.AddScoped<SolicitacaoService>();

// Permite a comunicação com o frontend durante o desenvolvimento
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider
        .GetRequiredService<TextQualid2Context>();

    context.Database.EnsureCreated();
}

// Documentação da API
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Configuração da comunicação com o frontend
app.UseCors("Frontend");

app.UseHttpsRedirection();

// CADASTRAR SOLICITAÇÃO
app.MapPost("/solicitacoes", (Solicitacao solicitacao, SolicitacaoService service) =>
{
    var criada = service.Criar(solicitacao);

    return Results.Ok(criada);
});

// LISTAR TODAS AS SOLICITAÇÕES
app.MapGet("/solicitacoes", (SolicitacaoService service) =>
{
    return Results.Ok(service.ListarTodas());
});

// BUSCAR SOLICITAÇÃO PELO PROTOCOLO
app.MapGet("/solicitacoes/protocolo/{protocolo}", 
    (string protocolo, SolicitacaoService service) =>
{
    var solicitacao = service.BuscarPorProtocolo(protocolo);

    if (solicitacao == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(solicitacao);
});

// BUSCAR SOLICITAÇÃO PELO ID
app.MapGet("/solicitacoes/{id:int}", 
    (int id, SolicitacaoService service) =>
{
    var solicitacao = service.BuscarPorId(id);

    if (solicitacao == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(solicitacao);
});

// ATUALIZAR STATUS DA SOLICITAÇÃO
app.MapPut("/solicitacoes/{id:int}/status",
    (int id, AtualizarStatusRequest request, SolicitacaoService service) =>
{
    var atualizada = service.AtualizarStatus(
        id,
        request.Status,
        request.Observacoes
    );

    if (!atualizada)
    {
        return Results.NotFound();
    }

    return Results.Ok(service.BuscarPorId(id));
});

app.Run();

public record AtualizarStatusRequest(string Status, string Observacoes);
