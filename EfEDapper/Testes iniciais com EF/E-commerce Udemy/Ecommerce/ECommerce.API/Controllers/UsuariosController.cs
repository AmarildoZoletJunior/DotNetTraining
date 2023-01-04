using eCommerce.Models.Modelop;
using ECommerce.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public IUsuarioRepository Repository { get; }
        public UsuariosController(IUsuarioRepository repository)
        {
            Repository = repository;
        }

        //{enderecoSite}/api/usuarios
        [HttpGet]
        public IActionResult Get()
        {
            var listaUsuarios = Repository.Get();

            return Ok(listaUsuarios);
        }
        [HttpGet("{id}")]
    
           public IActionResult Get(int id)
        {
            var ListaUsuario = Repository.Get(id);
            if(ListaUsuario == null)
            {
                return NotFound("Não encontrado");
            }
            return Ok(ListaUsuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Usuario usuario)
        {
            Repository.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Usuario usuario,int id)
        {
            Repository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            Repository.Delete(id);
            return Ok();
        }
    }
}
