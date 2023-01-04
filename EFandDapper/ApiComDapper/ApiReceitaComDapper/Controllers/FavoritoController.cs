using ApiReceitaComDapper.Entidades.Favoritos;
using ApiReceitaComDapper.Repository.Favoritos;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ApiReceitaComDapper.Controllers
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

        public async Task<IActionResult> ListarFavoritoUsuario([Required] int id)
        {
            var lista = await _Ifav.FavoritosUsuario(id);
            if (lista.Any())
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

        [HttpPost]

        public async Task<IActionResult> AdicionarFavoritos([Required][FromBody] FavoritosRequest favorito)
        {
            var insercao = await _Ifav.AdicionarFavoritos(favorito);
            if (insercao)
            {
                return Ok("Adicionado com sucesso");
            }
            return BadRequest();
        }

        [HttpDelete("{idUsuario:int}")]

        public async Task<IActionResult> RemoverFavoritos([Required] int idUsuario, [Required] int idReceita)
        {
            var remocao = await _Ifav.RemoverFavoritos(idUsuario, idReceita);

            if (remocao)
            {
                return Ok("Deletado com sucesso");
            }
            return NotFound();
        }
    }
}
