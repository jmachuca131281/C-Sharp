﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Areas.Usuario.Controllers
{
    public class UsuarioController : Controller
    {
        [Area("Usuario")]
        public IActionResult Usuario()
        {
            return View();
        }
    }
}