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
            //var cli1 = new Cliente()
            //{
                
            //    Nome = "Andre Sombra"
            //    ,
            //    DataNascimento = new DateTime(1975, 3, 31)
            //    ,
            //    Cidade = "Fortaleza"
            //    ,
            //    Estado = "Ceara"
            //    ,
            //    Endereco = "Rua Nove, 40"
            //    ,
            //    CPF = "580.941.213-00"
            //    ,
            //    Sexo = "M"
            //};
            //    await _clienteService.Incluir(cli1);

            //var cli2 = new Cliente()
            //{

            //    Nome = "Andre Sombra XXXXX"
            //    ,
            //    DataNascimento = new DateTime(1975, 3, 31)
            //    ,
            //    Cidade = "Fortaleza"
            //    ,
            //    Estado = "Ceara"
            //    ,
            //    Endereco = "Rua Nove, 40"
            //    ,
            //    CPF = "580.941.213-00"
            //    ,
            //    Sexo = "M"
            //};
            //await _clienteService.Incluir(cli2);



            Cliente = await _clienteService.ListarTodosClientes();
        }
    }
}
