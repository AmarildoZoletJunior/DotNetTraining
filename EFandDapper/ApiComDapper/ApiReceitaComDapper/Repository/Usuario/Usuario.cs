namespace ApiReceitaComDapper.Repository.Usuario
{
    public class Usuario
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Favoritos(IConfiguration configuration)
        {
            config = configuration;
            connection = config.GetConnectionString("ConexaoBancoReceita");
        }

    }
}
