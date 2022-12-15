using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbTarefa>(options => options.UseInMemoryDatabase("TarefaDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


#region Requisições
app.MapGet("/Tarefa/{id}", async (int id, DbTarefa db) =>
    await db.Tarefas.FindAsync(id) is Tarefa tarefa ? Results.Ok(tarefa) : Results.NotFound("Resultado não encontrado"));


app.MapGet("/Tarefas", (DbTarefa db) =>
{
    if (db.Tarefas.ToList() == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.Tarefas.ToList());
});

app.MapPost("/CriarTarefas", (Tarefa tarefa, DbTarefa db) =>
{
    if (tarefa == null)
        return Results.NotFound("Tarefa não é valida");
    db.Tarefas.Add(tarefa);
    db.SaveChanges();
    return Results.Ok(tarefa);
});

app.MapDelete("/Tarefa/{id}", async (int id, DbTarefa db) =>
{
    var pesquisado = await db.Tarefas.FindAsync(id);
    if (pesquisado != null)
    {
        db.Tarefas.Remove(pesquisado);
        db.SaveChanges();
        return Results.Ok("Deletado com sucesso");
    }
    return Results.NotFound("Tarefa não encontrada");
});


app.MapPut("/Tarefa/{id}", async (int id, Tarefa tarefa, DbTarefa db) =>
{
    if (id != tarefa.Id)
    {
        return Results.NotFound("Não foi encontrado nenhuma tarefa com este id");
    }

    var pesquisa = await db.Tarefas.FindAsync(id);
    if (pesquisa != null)
    {
        pesquisa.Nome = tarefa.Nome;
        pesquisa.EstaPronta = tarefa.EstaPronta;
        db.SaveChanges();
        return Results.Ok(pesquisa);
    }
    return Results.NotFound();
});

#endregion


app.Run();


#region Data
class DbTarefa : DbContext
{
    public DbTarefa(DbContextOptions<DbTarefa> options) : base(options)
    { }

    public DbSet<Tarefa> Tarefas { get; set; }
}

#endregion

#region Entidade
class Tarefa
{
    public string? Nome { get; set; }
    public bool EstaPronta { get; set; }
    public int Id { get; set; }

}
#endregion