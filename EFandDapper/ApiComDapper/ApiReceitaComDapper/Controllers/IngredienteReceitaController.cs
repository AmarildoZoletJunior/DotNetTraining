using ApiReceitaComDapper.Repository.IngredientesReceitas;
using Microsoft.AspNetCore.Mvc;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("IngredientesReceita/[Controller]")]
    public class IngredienteReceitaController : ControllerBase
    {
        private readonly IIngredienteReceita _receita;

        public IngredienteReceitaController(IIngredienteReceita receita)
        {
            _receita = receita;
        }

        [HttpGet]
        public async 
    }
}
