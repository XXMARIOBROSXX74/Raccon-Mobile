using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_sockets.Models
{
    public class Orden
    {
       
        public string? Nombre{get; set;}

        public string? Apellidos { get; set; }

        public string? Problema { get; set; }
        public string? Telefono { get; set; }

        public string? Fecha { get; set; }
        public string? Direccion { get; set; }
    }
}