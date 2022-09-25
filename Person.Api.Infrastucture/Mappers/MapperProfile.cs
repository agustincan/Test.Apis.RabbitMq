using AutoMapper;
using Person.Api.Domain.Dtos;
using Person.Api.Domain.Entities;

namespace Person.Api.Infrastucture.Mappers;

public class MapperProfile: Profile
{
    public MapperProfile()
    {
        CreateMap<PersonDto, Domain.Entities.Person>().ReverseMap();
        CreateMap<AddressDto, Address>().ReverseMap();
    }
}