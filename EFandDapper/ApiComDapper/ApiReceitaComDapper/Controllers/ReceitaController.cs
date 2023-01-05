using ApiReceitaComDapper.Repository.Receita;
using Microsoft.AspNetCore.Mvc;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("Receita/[Controller]")]
    public class ReceitaController : ControllerBase
    {

        private readonly IReceita _Ireceita;
        public ReceitaController(IReceita ireceita)
        {
            _Ireceita = ireceita;
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarReceita(int IdReceita)
        {

        }

    }
}
