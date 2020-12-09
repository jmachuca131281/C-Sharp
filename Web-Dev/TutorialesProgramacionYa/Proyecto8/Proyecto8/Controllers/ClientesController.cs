using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto8.Controllers
{
    public class ClientesController : Controller
    {
        public ActionResult Listado()
        {
            return View();
        }

        public ActionResult Alta()
        {
            return View();
        }
    }
}