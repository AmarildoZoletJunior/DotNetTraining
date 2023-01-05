using ApiReceitaComDapper.Repository.Favoritos;
using ApiReceitaComDapper.Repository.Ingredientes;
using ApiReceitaComDapper.Repository.IngredientesReceitas;
using ApiReceitaComDapper.Repository.Receita;
using ApiReceitaComDapper.Repository.UnMedida;
using ApiReceitaComDapper.Repository.Usuario;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFavoritos,Favoritos>();
builder.Services.AddScoped<IIngrediente, Ingrediente>();
builder.Services.AddScoped<IIngredienteReceita, IngredienteReceita>();
builder.Services.AddScoped<IReceita, Receita>();
builder.Services.AddScoped<IUnMedida, UnMedida>();
builder.Services.AddScoped<IUsuario, Usuario>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
