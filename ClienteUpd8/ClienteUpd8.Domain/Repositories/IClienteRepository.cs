using ClienteUpd8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteUpd8.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAll();
        Cliente GetById(int id);
        Task Add(Cliente cliente);
        Task Update(Cliente cliente);
        void Delete(int id);
    }
}
