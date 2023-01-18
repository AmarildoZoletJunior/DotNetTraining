using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Services.Validators;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _user;
        public UserController(IUserRepository user)
        {
            _user = user;
        }
        [HttpGet]

        public async Task<IActionResult> ListarUsuarios()
        {
            var lista = _user.ListarUsuarios();
            if (lista.Any())
            {
                return Ok(lista);
            }
            return BadRequest();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]User user)
        {
           _user.AdicionarUsuario(user);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> EditarUsuario([Required][FromBody] User user)
        {
            _user.EditarUsuario(user);
            return Ok();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> ListarUsuario(int id)
        {
            var usuario = _user.ListarUsuario(id);
            if(usuario != null)
            {
                return Ok(usuario);
            }
            return BadRequest();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletarUser(int id) {
           _user.RemoverUsuario(id);
            return Ok();
        }
    }
}
