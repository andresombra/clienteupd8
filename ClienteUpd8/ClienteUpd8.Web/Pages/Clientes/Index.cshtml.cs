using ClienteUpd7.Application.Interfaces;
using ClienteUpd8.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteUpd8.Web.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public IEnumerable<Cliente> Cliente { get; set; } = default!;

        private readonly IClienteService _clienteService;

        public IndexModel(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task OnGet()
        {
            Cliente = await _clienteService.ListarTodosClientes();
        }
    }
}
