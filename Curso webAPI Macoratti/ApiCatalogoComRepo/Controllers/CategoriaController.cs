using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Repository.UOW;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly IUnitOfWork _Uow;
        public CategoriaController(IUnitOfWork Uow)
        {
            _Uow = Uow;
        }

        [HttpGet("/Categorias")]

        public ActionResult<IEnumerable<Categoria>> Categorias()
        {
            var CategoriasPesquisada = _Uow.CategoriaRepository.GetAll().ToList();
            if (CategoriasPesquisada == null)
            {
                return NotFound("Não foi encontrado nenhuma Categoria");
            }
            return Ok(CategoriasPesquisada);
        }


        [HttpGet("/Categoria/{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Categoria([FromRoute]int id)
        {
   
                var CategoriaPesquisada = _Uow.CategoriaRepository.GetPorId(x => x.CategoriaId == id);
                if (CategoriaPesquisada == null)
                {
                    return NotFound("Não foi encontrado nenhuma Categoria");
                }
                return Ok(CategoriaPesquisada);
           
         
        }

        [HttpPost("/Categoria")]
        public ActionResult Categoria([FromBody] Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Categoria não é valido");
            }
            _Uow.CategoriaRepository.Add(categoria);
            _Uow.Commit();
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("/Categoria")]
        public ActionResult AlterarProduto([FromBody] Categoria categoria)
        {
            var pesquisa = _Uow.CategoriaRepository.GetPorId(x => x.CategoriaId == categoria.CategoriaId);
            if (pesquisa == null)
                return NotFound();
            _Uow.CategoriaRepository.Update(categoria);
            _Uow.Commit();
            return Ok(categoria);
        }

        [HttpDelete("/Categoria/{id:int}")]

        public ActionResult DeletarProduto(int id)
        {
            var CategoriaPesquisada = _Uow.CategoriaRepository.GetPorId(x => x.CategoriaId == id);
            if (CategoriaPesquisada is null)
            {
                return NotFound("Categoria não encontrado");
            }
            _Uow.CategoriaRepository.Delete(CategoriaPesquisada);
            _Uow.Commit();
            return Ok(CategoriaPesquisada);
        }

        [HttpGet("/Categoria/Produtos/{id:int}")]
        public ActionResult<IEnumerable<Produto>> ListarProdutosDeCategoria(int id)
        {
            var CategoriaPesquisada = _Uow.ProdutoRepository.GetPorCategorias(id);
            return Ok(CategoriaPesquisada);
        }

    }
}
