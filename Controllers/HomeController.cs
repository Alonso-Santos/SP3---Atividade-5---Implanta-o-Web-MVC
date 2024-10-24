using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Bruno alberto Passos", "857.032.950-41", "bruno.passos@sp.senai.br", "Marley");
        Cliente cliente2 = new Cliente(02, "Amanda Morais Lima", "039.618.250-09", "a.lima@aluno.df.com", "Lili");
        Cliente cliente3 = new Cliente(03, "Luan Ribeiro Mendes", "800.777.920-50", "luan01@2012.au.com", "Caramelo");
        Cliente cliente4 = new Cliente(04, "Roberta Almeida Paiva", "933.622.400-03", "roberta.p@iva.com.br", "Pitoco");
        Cliente cliente5 = new Cliente(05, "Graziele Bela", "911.702.988-00", "gra@bela.com.br", "Chuchu");

        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        
        ViewBag.listaClientes = listaClientes;

        // instâncias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pet S/A", "14.182.102/0001-80", "C-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet Inc", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        // lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy() 
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
