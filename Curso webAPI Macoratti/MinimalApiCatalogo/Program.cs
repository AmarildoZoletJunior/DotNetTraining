using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalApiCatalogo.Configuration;
using MinimalApiCatalogo.Data;
using MinimalApiCatalogo.DTO;
using MinimalApiCatalogo.Models;
using MinimalApiCatalogo.Validators;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
#region Configurações
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IConfig, Config>();
builder.Services.AddDbContext<DbClass>();
#endregion

var app = builder.Build();

#region Categoria
app.MapPost("/categorias", (DbClass db, [Required]Categoria categoria) =>
{
    var validation = new CategoriaValidation();
    var resultado = validation.Validate(categoria);
    if (resultado.IsValid)
    {
        return Results.BadRequest("Algum campo da categoria não esta valido");
    }

    if(categoria != null)
    {
        db.Categorias.Add(categoria);
        db.SaveChanges();
        return Results.Created($"/categorias/{categoria.Id}", categoria);
    }
    return Results.BadRequest("Algum campo da categoria não esta valido");

}).WithTags("Categorias");



app.MapGet("/categoria/{id:int}", (DbClass db,[Required]int id) =>
{
    var Pesquisa = db.Categorias.FirstOrDefault(X => X.Id == id);
    if (Pesquisa != null)
    {
        var dtoPesquisa = new CategoriaDTO { Descricao = Pesquisa.Descricao, Nome = Pesquisa.Nome, Id = Pesquisa.Id };
        return Results.Ok(dtoPesquisa);
    }
    return Results.NotFound("Não foi encontrada nenhuma categoria");
}).WithTags("Categorias");

app.MapGet("/categorias", (DbClass db) =>
{
    var pesquisaTotal = db.Categorias.ToList();
    var dtoPesquisa = new List<CategoriaDTO>();
    if(pesquisaTotal != null)
    {
        dtoPesquisa = pesquisaTotal.Select(c => new CategoriaDTO { Nome = c.Nome, Descricao = c.Descricao, Id = c.Id}).ToList();
        return Results.Ok(dtoPesquisa);
    }
    return Results.NotFound("Não foi encontrada nenhuma categoria");
}).WithTags("Categorias");

app.MapPut("/categorias", (DbClass db,[Required]Categoria categoria) =>
{
    var validation = new CategoriaValidation();
    var resultado = validation.Validate(categoria);
    if(resultado.IsValid)
        return Results.BadRequest("Categoria está com campos invalido.");

    var Pesquisa = db.Categorias.FirstOrDefault(x => x.Id == categoria.Id);

    if(Pesquisa == null)
        return Results.NoContent();
 
    db.Categorias.Update(categoria);
    db.SaveChanges();
    return Results.Ok(categoria);
}).WithTags("Categorias");


app.MapDelete("/categorias/{id:int}", (DbClass db, [Required]int id) =>
{
    var Pesquisa = db.Categorias.FirstOrDefault(x => x.Id == id);
    if (Pesquisa == null)
        return Results.NotFound("Não foi encontrado a categoria para remoção");

    db.Categorias.Remove(Pesquisa);
    db.SaveChanges();
    return Results.Ok("Removida com sucesso");
}).WithTags("Categorias");
#endregion

#region Produto
app.MapGet("/produtos", (DbClass db) =>
{
    var Pesquisa = db.Produtos.ToList();
    var ProdDTO = new List<ProdutoDTO>();
    if(Pesquisa.Any())
    {
        var ProdDto = db.Produtos.Include(x => x.Categoria).Select(x => new ProdutoDTO { Nome = x.Nome, Preco = x.Preco, DataCompra = x.DataCompra, Descricao = x.Descricao, Estoque = x.Estoque, ImagemI = x.ImagemI, CategoriaTipo = x.Categoria.Nome, Id = x.Id }).ToList();
        return Results.Ok(ProdDto);
    }
    return Results.NoContent();

}).WithTags("Produto");


app.MapGet("/produto/{id:int}", (DbClass db, [Required]int id) =>
{
    var Pesquisa = db.Produtos.Include(x => x.Categoria).FirstOrDefault(x => x.Id == id);
    if(Pesquisa != null)
    {
        var ProdDTO = new ProdutoDTO { Nome = Pesquisa.Nome, Preco = Pesquisa.Preco, DataCompra = Pesquisa.DataCompra, Descricao = Pesquisa.Descricao, Estoque = Pesquisa.Estoque, ImagemI = Pesquisa.ImagemI, CategoriaTipo = Pesquisa.Categoria.Nome, Id = Pesquisa.Id };
        return Results.Ok(ProdDTO);
    }
    return Results.NoContent();
}).WithTags("Produto");

app.MapGet("/produtos/categoria/{id:int}", (DbClass db, [Required] int id) =>
{
    var pesquisa = db.Categorias.Include(x => x.Produtos).FirstOrDefault(x => x.Id == id);
    if (pesquisa == null)
        return Results.NotFound("Esta categoria não existe");

    if (pesquisa.Produtos == null) return Results.NotFound("Não existe produtos cadastrados nesta categoria");

    var ProdDTO = new List<ProdutoDTO>();
    ProdDTO = pesquisa.Produtos.Select(x => new ProdutoDTO { CategoriaTipo = pesquisa.Nome ,DataCompra = x.DataCompra, Descricao = x.Descricao, Estoque = x.Estoque, ImagemI = x.ImagemI, Nome = x.Nome, Preco = x.Preco, Id = x.Id }).ToList();
    return Results.Ok(ProdDTO);
});



app.MapPost("/produto", (DbClass db, [Required]Produto produto) =>
{
    var validation = new ProdutoValidation();
    var resultado = validation.Validate(produto);
    if (resultado.IsValid)
    {
        return Results.BadRequest("Você deixou algum campo invalido");
    }
    if (produto != null)
    {
        db.Produtos.Add(produto);
        db.SaveChanges();
        return Results.Ok("Produto criado com sucesso");
    }
    return Results.BadRequest("Você deixou algum campo invalido");

}).WithTags("Produto");


app.MapPut("/produto", (DbClass db, [Required] Produto produto) =>
{
    var validation = new ProdutoValidation();
    var resultado = validation.Validate(produto);
    //Fazer validação antes do resultado
    if (resultado.IsValid)
    {
        return Results.BadRequest("Existe campos invalidos");
    }
    var pesquisa = db.Produtos.AsNoTracking().FirstOrDefault(x => x.Id == produto.Id);
    if(pesquisa != null)
    {
        db.Produtos.Update(produto);
        db.SaveChanges();
        return Results.Ok("Modificado com sucesso");
    }
    return Results.BadRequest("Existe campos invalidos");

}).WithTags("Produto");


app.MapDelete("/produto/{id:int}", async (DbClass db, [Required]int id) =>
{
    var pesquisa = await db.Produtos.FirstOrDefaultAsync(x => x.Id == id);
    if(pesquisa != null)
    {
        db.Produtos.Remove(pesquisa);
        db.SaveChanges();
        return Results.Ok($"{pesquisa.Nome} foi removido com sucesso");
;    }
    return Results.NotFound("Este produto não existe");
}).WithTags("Produto");
#endregion


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();


