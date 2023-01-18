using ApiCatalogo.Data;
using ApiCatalogo.DTO;
using ApiCatalogo.Models;
using ApiCatalogo.Repository.UOW;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public CategoriaController(IUnitOfWork Uow,IMapper map)
        {
            _mapper = map;
            _Uow = Uow;
        }

        [HttpGet("/Categorias")]

        public ActionResult<IEnumerable<CategoriaDTO>> Categorias()
        {
            var CategoriasPesquisada = _Uow.CategoriaRepository.GetAll().ToList();
            if (CategoriasPesquisada == null)
            {
                return NotFound("Não foi encontrado nenhuma Categoria");
            }
            var mapeamento = _mapper.Map<List<CategoriaDTO>>(CategoriasPesquisada);
            return Ok(mapeamento);
        }


        [HttpGet("/Categoria/{id:int}", Name = "ObterCategoria")]
        public ActionResult<CategoriaDTO> Categoria([FromRoute]int id)
        {
   
                var CategoriaPesquisada = _Uow.CategoriaRepository.GetPorId(x => x.CategoriaId == id);
                if (CategoriaPesquisada == null)
                {
                    return NotFound("Não foi encontrado nenhuma Categoria");
                }
            return Ok(CategoriaPesquisada);
           
         
        }

        [HttpPost("/Categoria")]
        public ActionResult Categoria([FromBody] CategoriaDTO categoria)
        {
            if (categoria is null)
            {
                return BadRequest("Categoria não é valido");
            }
            var categoriaConversao = _mapper.Map<Categoria>(categoria);
            _Uow.CategoriaRepository.Add(categoriaConversao);
            _Uow.Commit();
            return new CreatedAtRouteResult("ObterCategoria", new { id = categoria.CategoriaId }, categoriaConversao);
        }

        [HttpPut("/Categoria")]
        public ActionResult AlterarProduto([FromBody] CategoriaDTO categoria)
        {
            var categoriaConversao = _mapper.Map<Categoria>(categoria);
            var pesquisa = _Uow.CategoriaRepository.GetPorId(x => x.CategoriaId == categoria.CategoriaId);
            if (pesquisa == null)
                return NotFound();

            _Uow.CategoriaRepository.Update(categoriaConversao);
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
        public ActionResult<IEnumerable<CategoriaDTO>> ListarProdutosDeCategoria(int id)
        {
            var CategoriaPesquisada = _Uow.ProdutoRepository.GetPorCategorias(id);
            if (CategoriaPesquisada.Any())
            {
                return BadRequest();
            }
            var mapeamento = _mapper.Map<List<CategoriaDTO>>(CategoriaPesquisada);
            return Ok(mapeamento);
        }

    }
}
