using AutoMapper;
using MuvieApi.Data.Dtos;
using MuvieApi.Models;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<CreateAddressDto, Address>();
        CreateMap<UpdateAddressDto, Address>();
        CreateMap<Address, ReadAddressDto>();
    }
}