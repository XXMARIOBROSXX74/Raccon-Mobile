using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Web_sockets.Models;

namespace Web_sockets.Hubs
{
    public class MensajeHub : Hub
    {
        public async Task EnviarMensaje(Orden msj)
        {
           await Clients.All.SendAsync("EnviarMensajeTodos", msj.Nombre, msj.Apellidos, msj.Telefono, msj.Problema, msj.Direccion, msj.Fecha);

        }
         public async Task ActualizarEstado(string estado)
        {
            // Aquí puedes implementar lógica adicional según sea necesario.
            await Clients.All.SendAsync("EstadoActualizado", estado);
        }
    }
}
    

