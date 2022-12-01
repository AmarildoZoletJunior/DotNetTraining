using Microsoft.EntityFrameworkCore;
using ProjetoReceitas;
using ProjetoReceitas.Repositories;
using ProjetoReceitas.Repositories.ReceitaRepository;
using ProjetoReceitas.Repositories.UsuarioRepository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

#region ConfigurarServi�os 
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Conex�o com o banco
builder.Services.AddDbContext<DbArquivo>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("BuscasReceitas"))
    );

//Inje��o de depend�ncia
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IReceitaRepository, ReceitaRepository>();

#endregion

#region Configura��oPipeLine 
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
#endregion

