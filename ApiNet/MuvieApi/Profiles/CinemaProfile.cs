using AutoMapper;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Address, ReadAddressDto>();

        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(cinemaDto => cinemaDto.AddressDto, 
               opt => opt.MapFrom(cinema => cinema.Address))
               .ForMember(cinemaDto => cinemaDto.SectionsDto, 
               opt => opt.MapFrom(cinema => cinema.Sections));
    }
}