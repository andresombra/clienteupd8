using ClienteUpd8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteUpd7.Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ListarTodosClientes();
        Task<Cliente> BuscarId(int id);
        Task Incluir(Cliente cliente);
        Task Alterar(Cliente cliente);
        void Excluir(int id);
    }
}
