using AutoMapper;
using EditoraSpread.Application.DTOs.Autor;
using EditoraSpread.Application.DTOs.Genero;
using EditoraSpread.Application.DTOs.Livro;
using EditoraSpread.Domain.Entities;

namespace EditoraSpread.Application.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Autor 
        CreateMap<Autor, AutorDto>().ReverseMap();
        CreateMap<AutorCreateDto, Autor>();
        CreateMap<AutorUpdateDto, Autor>();

        // Genero
        CreateMap<Genero, GeneroDto>().ReverseMap();
        CreateMap<CreateGeneroDto, Genero>();
        CreateMap<UpdateGeneroDto, Genero>();

        // Livro
        CreateMap<Livro, LivroDto>().ReverseMap();
        CreateMap<CreateLivroDto, Livro>();
        CreateMap<UpdateLivroDto, Livro>();
    }
}
