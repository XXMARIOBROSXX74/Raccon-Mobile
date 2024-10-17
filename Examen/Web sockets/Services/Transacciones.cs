using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_sockets.Models;

namespace Web_sockets.Services
{
    public class Transacciones : ITransacciones
    {
        List<Orden> ordenes;
        public Transacciones()
        {
            ordenes = new List<Orden>();
        }

        public int Actualizar(Orden p)
        {
            Orden? temp = ordenes.FirstOrDefault(x => x.Telefono == p.Telefono);

            if (temp != null)
            {
                temp.Nombre = p.Nombre;
                temp.Apellidos = p.Apellidos;
                temp.Problema = p.Problema;
                temp.Telefono = p.Telefono;
                return ordenes.IndexOf(temp);
            }

            return -1;
        }


        public void Agregar(Orden p)
        {
            ordenes.Add(p);
        }

        public List<Orden> Consultar()
        {
            return ordenes;
        }

        public bool Eliminar(string telefono)
        {
            Orden? p = ordenes.FirstOrDefault(x => x.Telefono == telefono);
            if (p != null)
            {
                ordenes.Remove(p);
                return true;
            }
            return false;
        }


        public Orden ObtenerOrden(string Telefono)
        {
            return ordenes.FirstOrDefault(x => x.Telefono == Telefono)!;
        }
    }
}