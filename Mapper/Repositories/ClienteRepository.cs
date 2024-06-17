using AutoMapper;
using DataBase;
using Dtos;

namespace pruebaExperticket.Repositories
{
    public class ClienteRepository
    {
        private readonly IMapper mapper;
        public ClienteRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public ClienteDto GetClienteDto(Cliente client)
        {
            return mapper.Map<ClienteDto>(client);
        }

        public Cliente GetCliente(ClienteDto dto)
        {
            return mapper.Map<Cliente>(dto);
        }
    }
}
