using AutoMapper;
using DataBase;
using Dtos;

namespace pruebaExperticket.Profiles
{
    public class ClienteDtoProf : Profile
    {
        public ClienteDtoProf()
        {
            CreateMap<Cliente, ClienteDto>()
                .ForMember(d => d.DNI, d => d.MapFrom(a => a.DNI))
                .ForMember(d => d.Nombre, d => d.MapFrom(a => a.Nombre))
                .ForMember(d => d.Apellidos, d => d.MapFrom(a => a.Apellidos))
                .ForMember(d => d.Sexo, d => d.MapFrom(a => a.Sexo))
                .ForMember(d => d.FechaNacimiento, d => d.MapFrom(a => a.FechaNacimiento))
                .ForMember(d => d.Direccion, d => d.MapFrom(a => a.Direccion))
                .ForMember(d => d.Pais, d => d.MapFrom(a => a.Pais))
                .ForMember(d => d.CodigoPostal, d => d.MapFrom(a => a.CodigoPostal))
                .ForMember(d => d.Email, d => d.MapFrom(a => a.Email));
        }

    }
}
