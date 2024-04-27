using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bancaweb.Models;
using bancaweb.Data;

namespace bancaweb.Controllers
{
 
    public class RegistrarCuentasController : Controller
    {
        private readonly ILogger<RegistrarCuentasController> _logger;

        public RegistrarCuentasController(ILogger<RegistrarCuentasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    
    
        [HttpPost]
        public IActionResult EnviarMensaje(RegistrarCuentas objRegistrarCuentas)
        {
            _logger.LogDebug("INGRESO A ENVIAR MENSAJE");
            ViewData["Message"]="Se registro la cuenta";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}