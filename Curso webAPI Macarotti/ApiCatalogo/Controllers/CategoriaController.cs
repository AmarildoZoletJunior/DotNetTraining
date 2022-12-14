using ApiCatalogo.Data;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class CategoriaController : ControllerBase
    {
        private readonly CatalogoContext _catalogoContext;
        public CategoriaController(CatalogoContext catalogoContext)
        {
            _catalogoContext = catalogoContext;
        }

        [HttpGet("/Produto")]
        public List<Categoria> teste()
        {
            return _catalogoContext.Categorias.ToList();
        }


    }
}
