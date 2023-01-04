using Microsoft.AspNetCore.Mvc;
using ProjetoReceitas.Repositories.UsuarioRepository;
using Receitas.Models.Models;

namespace ProjetoReceitas.Controllers
{
    [Route("ApiGoogleReceitas/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet("{id}")]
        public IActionResult UnicoUsuario(int id)
        {
         Usuario usuario = _usuarioRepository.UnicoUsuario(id);
            if(usuario == null)
            {
                return NotFound("Não encontrado");
            }
            else
            {
                return Ok(usuario);
            }
        }

        [HttpPost]
        public IActionResult AdicionarUsuario([FromBody]Usuario usuario)
        {
           _usuarioRepository.CriarConta(usuario);
           return Ok(usuario);
        }

        [HttpPut]
        public IActionResult AtualizarUsuario([FromBody]Usuario usuario)
        {
            _usuarioRepository.AtualizarConta(usuario);
            return Ok(usuario);
        }
        [HttpDelete("{id}")]
        public IActionResult RemoverUsuario(int id)
        {
            _usuarioRepository.DeletarConta(id);
            return Ok();
        }
    }
}
