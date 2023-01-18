using ApiCatalogo.Models;
using AutoMapper;

namespace ApiCatalogo.DTO.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();  
        }
    }
}
