namespace TesteComEf.DTO
{
    public class ReceitaResponse
    {
        public int IdReceita { get; set; }
        public string TituloReceita { get; set; }
        public int Rendimento { get; set; }
        public string ModoPreparo { get; set; }
        public List<IngredientesReceitaResponse>? IngredientesReceita { get; set; }
        public int IdUsuarioDono { get; set; }
    }
}
