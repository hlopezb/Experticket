using Dtos;
using DataBase;
using pruebaExperticket.Repositories;
using AutoMapper;

namespace Model
{
    public class ClienteModel
    {
        private static ClienteModel instance = null;
        private ClienteRepository repository;
        private Context _context;

        public static ClienteModel GetInstance()
        {
            if (instance == null)
                instance = new ClienteModel();
            return instance;
        }

        private ClienteModel(Context context)
        {
            repository = new ClienteRepository(IMapper mapper);
            _context = context;
        }

        public ClienteDto GetClient(string DNI)
        {
            var client = _context.Clientes.FirstOrDefault(a => a.DNI == DNI);
            if (client == null)
                return new ClienteDto();
            return repository.GetClienteDto(client);
        }

        public void CreateClient(ClienteDto dto)
        {
            var client = repository.GetCliente(dto);
            _context.Clientes.Add(client);
            _context.SaveChanges();
        }

        public void UpdateClient(ClienteDto dto)
        {
            using (var _context = new Context())
            {
                var client = _context.Clientes.FirstOrDefault(a => a.DNI == dto.DNI);
                if (client != null)
                {
                    client.Nombre = dto.Nombre;
                    client.Apellidos = dto.Apellidos;
                    client.Direccion = dto.Direccion;
                    client.CodigoPostal = dto.CodigoPostal;
                    client.FechaNacimiento = dto.FechaNacimiento;
                    client.Sexo = dto.Sexo;
                    client.Email = dto.Email;
                    client.Pais = dto.Pais;
                    _context.SaveChanges();
                }
            }
        }

        public void DeleteClient(string DNI)
        {
            var client = _context.Clientes.FirstOrDefault(a => a.DNI == DNI);
            if (client != null)
            {
                _context.Clientes.Remove(client);
                _context.SaveChanges();
            }
        }

        public List<ClienteDto> ListClients()
        {
            return _context.Clientes.Select(a => repository.GetClienteDto(a)).ToList();
        }
    }
}
