using Microsoft.AspNetCore.Mvc;
using SistemaFacturacion.Models;
using System.Diagnostics;
using System.Data.SqlClient;
using SistemaFacturacion.Data;

namespace SistemaFacturacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataAcces dataAcces;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            dataAcces = new DataAcces();
        }

        public IActionResult Index()
        {
            List<Cliente> clientes = dataAcces.ObtenerClientes();
            return View(clientes);
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
}
