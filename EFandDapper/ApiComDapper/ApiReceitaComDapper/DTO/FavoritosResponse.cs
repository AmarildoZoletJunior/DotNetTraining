namespace TesteComEf.DTO
{
    public class FavoritosResponse
    {
        public string NomeUsuario { get; set; } = null!;
        public int Idusuario { get; set; }
        public string NomeReceita { get; set; } = null!;

        public int IdReceita { get; set; }
    }
}
