namespace ApiReceitaComDapper.Entidades.Receita
{
    public class ReceitaRequest
    {
        public string TituloReceita { get; set; } = null!;
        public int Rendimento { get; set; }
        public string ModoPreparo { get; set; } = null!;
        public int IdUsuario { get; set; }
        public string tipo_receita { get; set; }
    }
}
