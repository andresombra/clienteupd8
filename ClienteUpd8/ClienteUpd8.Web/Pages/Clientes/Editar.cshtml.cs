using ClienteUpd7.Application.Interfaces;
using ClienteUpd8.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteUpd8.Web.Pages.Clientes
{
    public class EditarModel : PageModel
    {
        private readonly IClienteService _clienteService;

        public EditarModel(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task OnGet(int Id)
        {
            Cliente = await _clienteService.BuscarId(Id);
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            await _clienteService.Alterar(Cliente);

            return RedirectToPage("Index");
        }
    }
}
