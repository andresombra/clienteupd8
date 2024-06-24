using ClienteUpd7.Application.Interfaces;
using ClienteUpd8.Domain.Entities;
using ClienteUpd8.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteUpd7.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
          _clienteRepository = clienteRepository;
        }

        public async Task Alterar(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
        }

        public async Task<Cliente> BuscarId(int id)
        {
            return _clienteRepository.GetById(id); 
        }

        public void Excluir(int id)
        {
            _clienteRepository.Delete(id);
        }

        public Task Incluir(Cliente cliente)
        {
            return _clienteRepository.Add(cliente);
        }

        public async Task<IEnumerable<Cliente>> ListarTodosClientes()
        {
            return await _clienteRepository.GetAll();
        }
    }
}
