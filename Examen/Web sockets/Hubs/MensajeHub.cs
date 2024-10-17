using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Web_sockets.Hubs
{
    public class MensajeHub : Hub
    {
        public async Task EnviarMensaje(String msj)
        {
            await Clients.All.SendAsync("EnviarDatosChalam", msj);
        }
    }
}