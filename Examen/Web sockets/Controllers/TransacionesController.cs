using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_sockets.Models;
using Web_sockets.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web_sockets.Controllers
{
    public class TransaccionesController : Controller
    {
        private readonly ITransacciones db;
        public TransaccionesController(ITransacciones db){
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetOrdenes(){
            return Json(db.Consultar());
        }
        [HttpGet]
        public IActionResult GetOrden(string Telefono){
            return Json(db.ObtenerOrden(Telefono));
            }
        [HttpPost]
        public IActionResult AddOrden([FromBody]Orden p){
            db.Agregar(p);
            return Json(new {Mensaje ="Insertado correctamente"});
        }
        [HttpPost]
        public IActionResult updateOrden([FromBody] Orden p){
            int result = db.Actualizar(p);
            if(result == -1){
                return Json(new{Mensaje = "No actualizado"});
            }
            return Json(new{Mensaje = "Actualizado Correctamente"});
        }
        [HttpPost]
        public IActionResult Eliminar(string telefono){
            bool eliminar = db.Eliminar(telefono);
            if(eliminar){
                return Json(new{Mensaje = "Eliminado"});
            }
            return Json (new{Mensaje ="No se a eliminado correctamente"});
        }
    }
}