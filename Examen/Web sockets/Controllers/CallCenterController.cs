using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Web_sockets.Hubs;
using Web_sockets.Models;

namespace Web_sockets.Controllers
{
    public class CallCenterController : Controller
    {
        private readonly IHubContext<MensajeHub> hubContext;

        public CallCenterController(IHubContext<MensajeHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public IActionResult Ordenes()
        {
            return View();
        }

        public IActionResult Encargado()
        {
            return View();
        }

        public IActionResult Empleado()
        {
            return View();
        }

        public IActionResult Mapa()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Procesar([FromBody] Orden p)
        {
            await hubContext.Clients.All.SendAsync("EnviarMensajeTodos", p.Nombre, p.Apellidos, p.Telefono, p.Problema, p.Direccion, p.Fecha);

            return Json(p);
        }
    }
}
