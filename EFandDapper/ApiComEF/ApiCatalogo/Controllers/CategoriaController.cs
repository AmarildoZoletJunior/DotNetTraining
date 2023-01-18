using ApiCatalogo.Data;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.WebEncoders.Testing;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections;
using System.Collections.Generic;

namespace ApiCatalogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly CatalogoContext _catalogoContext;
        public CategoriaController(CatalogoContext catalogoContext)
        {
            _catalogoContext = catalogoContext;
        }

        [HttpGet("/Categorias")]

        public ActionResult<IEnumerable<Categoria>> Categorias()
        {
            IEnumerable<Categoria> CategoriasPesquisada = _catalogoContext.Categorias.ToList();
            if (CategoriasPesquisada == null)
            {
                return NotFound("Não foi encontrado nenhuma Categoria");
            }
            return Ok(CategoriasPesquisada);
        }


        [HttpGet("/Categoria/{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Categoria([FromRoute]int id)
        {
            try
            {
                var CategoriaPesquisada = _catalogoContext.Categorias.AsNoTracking().FirstOrDefault(x => x.CategoriaId == id);
                if (CategoriaPesquisada == null)
                {
                    return NotFound("Não foi encontrado nenhuma Categoria");
                }
                return Ok(CategoriaPesquisada);
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        [HttpPost("/Categoria")]
        public ActionResult Categoria([FromBody] Categoria categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Categoria não é valido");
            }
            _catalogoContext.Categorias.Add(categoria);
            _catalogoContext.SaveChanges();
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoria);
        }

        [HttpPut("/Categoria/{id:int}")]
        public ActionResult AlterarProduto(int id, [FromBody] Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest("Categoria não encontrado");
            }
            _catalogoContext.Categorias.Update(categoria);
            _catalogoContext.SaveChanges();
            return Ok(categoria);
        }

        [HttpDelete("/Categoria/{id:int}")]

        public ActionResult DeletarProduto(int id)
        {
            var CategoriaPesquisada = _catalogoContext.Categorias.FirstOrDefault(x => x.CategoriaId == id);
            if (CategoriaPesquisada is null)
            {
                return NotFound("Categoria não encontrado");
            }
            _catalogoContext.Categorias.Remove(CategoriaPesquisada);
            _catalogoContext.SaveChanges();
            return Ok(CategoriaPesquisada);
        }

        [HttpGet("/Categoria/Produtos/{id:int}")]
        public ActionResult<IEnumerable<Categoria>> ListarProdutosDeCategoria(int id)
        {
            var CategoriaPesquisada = _catalogoContext.Categorias.Include(x => x.ListaProdutos).FirstOrDefault(x => x.CategoriaId == id);
            return Ok(CategoriaPesquisada);
        }

    }
}
