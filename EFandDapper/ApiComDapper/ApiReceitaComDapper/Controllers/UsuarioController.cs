using ApiReceitaComDapper.Entidades.Usuario;
using ApiReceitaComDapper.Repository.Usuario;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ApiReceitaComDapper.Controllers
{
    [ApiController]
    [Route("Usuario/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }


        [HttpPost]
        public async Task<IActionResult> RegistrarUsuario([Required][FromBody]UsuarioRequest usuario)
        {
            var existe = await _usuario.UsuarioExiste(usuario.Email);
            if (!existe)
            {
                var registro = await _usuario.CriarUsuario(usuario);
                if (registro)
                {
                    return Ok(usuario);
                }
                return NotFound();
            }
            return BadRequest();
        }

        [HttpPut]

        public async Task<IActionResult> EditarUsuario([Required][FromBody] UsuarioRequest usuario)
        {
                var atualizar = await _usuario.EditarUsuario(usuario);
                if (atualizar)
                {
                    return Ok(usuario);
                }
                return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> ListarUsuarios()
        {
            var usuarios = await _usuario.ListaUsuarios();
            if (usuarios.Any())
            {
                return Ok(usuarios);
            }
            return NoContent();
        }
    } 
}
