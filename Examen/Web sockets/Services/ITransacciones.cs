using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_sockets.Models;

namespace Web_sockets.Services
{
    public interface ITransacciones
    {
        public void Agregar(Orden p);
        public List<Orden> Consultar();
        public Orden ObtenerOrden(string Telefono);
        public int Actualizar(Orden p);
        public bool Eliminar(string Telefono); 
    }
}