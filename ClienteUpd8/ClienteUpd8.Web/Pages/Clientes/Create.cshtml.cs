using ClienteUpd7.Application.Interfaces;
using ClienteUpd8.Domain.Entities;
using ClienteUpd8.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ClienteUpd8.Web.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly IClienteService _clienteService;
        
        public CreateModel(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public void OnGet()
        {

        }

        //public void OnPost() {

        //    RedirectToPage("/List");
        //}

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            await _clienteService.Incluir(Cliente);
            
            return RedirectToPage("Index");
        }
    }
}
