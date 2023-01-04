using TarefasApi.EndPoints;
using TarefasApi.Extension;

var builder = WebApplication.CreateBuilder(args);
builder.AddPersistence();
var app = builder.Build();
app.MapTarefasEndPoints();


app.Run();
