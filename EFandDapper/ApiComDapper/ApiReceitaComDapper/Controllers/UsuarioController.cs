using ApiReceitaComDapper.Repository.Usuario;
using Microsoft.AspNetCore.Mvc;

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
    }
}
