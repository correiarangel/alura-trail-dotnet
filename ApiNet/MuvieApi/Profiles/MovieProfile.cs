using AutoMapper;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

namespace MuvieApi.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<UpdateMovieDto, Movie>();
        CreateMap<Movie, UpdateMovieDto>();

        CreateMap<Movie, ReadMovieDto>()
           .ForMember(filmeDto => filmeDto.Sections,
                   opt => opt.MapFrom(filme => filme.Sections));

    }
}