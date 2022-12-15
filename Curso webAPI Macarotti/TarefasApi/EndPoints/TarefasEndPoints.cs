using Dapper.Contrib.Extensions;
using System.Runtime.CompilerServices;
using TarefasApi.Data;
using static TarefasApi.Data.TarefaContext;

namespace TarefasApi.EndPoints
{
    public static class TarefasEndPoints
    {
        public static void MapTarefasEndPoints(this WebApplication app)
        {
            app.MapGet("/", () => "Bem vindo a tarefasAPI");
            app.MapGet("/tarefas", async (GetConnection connectionGeter) =>
            {
                using var con = await connectionGeter();
                var tarefas = con.GetAll<Tarefa>().ToList();
                if (tarefas is null)
                    return Results.NotFound();
                return Results.Ok(tarefas);
            });
            app.MapGet("/tarefa/{id:int}", async (GetConnection connectionGeter,int id) =>
            {
                using var con = await connectionGeter();
                var tarefa = con.Get<Tarefa>(id);
                if (tarefa is null)
                    return Results.NotFound();
                return Results.Ok(tarefa);
            });
            app.MapPost("/tarefa", async (GetConnection connectionGeter, Tarefa tarefa) =>
            {
                if (tarefa is null)
                    return Results.NotFound();
                using var con = await connectionGeter();
                var tarefaAdicionar = con.Insert(tarefa);
                return Results.Created("TarefaCriada",tarefa);
            });

            app.MapPut("/tarefa", async (GetConnection connectionGeter,Tarefa tarefa) =>
            {
                if (tarefa is null)
                    return Results.NotFound();

                using var con = await connectionGeter();
                var tarefaAdicionar = con.Update(tarefa);
                return Results.Ok();
            });

            app.MapDelete("/tarefa/{id:int}", async (GetConnection connectionGeter, int id) =>
            {
              
                using var con = await connectionGeter();
                var ProcurarTarefa = con.Get<Tarefa>(id);
                if (ProcurarTarefa is null)
                    return Results.NotFound();

                con.Delete(ProcurarTarefa);

                return Results.Ok(ProcurarTarefa);
            });
        }
    }
}
