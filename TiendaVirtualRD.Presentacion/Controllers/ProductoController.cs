using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaVirtualRD.Dominio;

namespace TiendaVirtualRD.Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ProductoAdm()
        {
            return View();
        }
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ProductoDTO producto)
        {
            return View();
        }

    }
}