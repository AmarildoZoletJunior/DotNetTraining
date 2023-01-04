using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TesteComEf.Repository.Favoritos;

namespace TesteComEf.Controllers
{
    [ApiController]
    [Route("Favorito/[Controller]")]
    public class FavoritoController : ControllerBase
    {
        private readonly IFavoritos _Ifav;
        public FavoritoController(IFavoritos ifav)
        {
            _Ifav = ifav;
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> ListarFavoritoUsuario([Required]int id)
        {
            var lista = await _Ifav.FavoritosUsuario(id);
            if(lista.Any())
            {
                return Ok(lista);
            }
            return NotFound("Não foi encontrado nada deste usuario");
        }

        [HttpGet]

        public async Task<IActionResult> ListarFavoritosGeral()
        {
            var lista = await _Ifav.FavoritosGeral();
            if (lista.Any())
            {
                return Ok(lista);
            }
            return NotFound("Este usuario não existe");
        }
    }
}
