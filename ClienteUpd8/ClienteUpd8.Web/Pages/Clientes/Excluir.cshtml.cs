using ClienteUpd7.Application.Interfaces;
using ClienteUpd8.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClienteUpd8.Web.Pages.Clientes
{
    public class ExcluirModel : PageModel
    {
        private readonly IClienteService _clienteService;

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;
        public ExcluirModel(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task OnGet(int Id)
        {
           
            Cliente = await _clienteService.BuscarId(Id);

            RedirectToAction("Index","Clientes");
            
        }

        public async Task<IActionResult> OnPost() {

            _clienteService.Excluir(Cliente.Id);

            //RedirectToAction("Index", "Clientes");
            return RedirectToPage("Index");

        }
    }
}
