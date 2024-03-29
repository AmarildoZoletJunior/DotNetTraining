﻿namespace ApiReceitaComDapper.DTO
{
    public class ReceitaResponse
    {
        public int IdReceita { get; set; }
        public string TituloReceita { get; set; }
        public int Rendimento { get; set; }
        public string ModoPreparo { get; set; }
        public IEnumerable<IngredientesReceitaResponse>? IngredientesReceita { get; set; }
        public int IdUsuarioDono { get; set; }
    }
}
