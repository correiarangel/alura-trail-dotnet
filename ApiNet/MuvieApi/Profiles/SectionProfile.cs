using AutoMapper;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

namespace MuvieApi.Profiles;

public class SectionProfile : Profile
{
    public SectionProfile()
    {
        CreateMap<CreateSectionDto, Section>();
        CreateMap<Section, ReadSectionDto>();
    }
}