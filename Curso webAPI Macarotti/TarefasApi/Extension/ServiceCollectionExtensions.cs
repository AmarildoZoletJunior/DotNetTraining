using System.Data.SqlClient;
using static TarefasApi.Data.TarefaContext;

namespace TarefasApi.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("TarefasDemoDb");
            builder.Services.AddScoped<GetConnection>(sp => async () =>
            {
                var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            });
            return builder;
        }
    }
}
