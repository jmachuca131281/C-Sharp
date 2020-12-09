using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Usuarios.Areas.Principal.Controllers;
using Usuarios.Library;
using Usuarios.Models;

namespace Usuarios.Controllers
{
    public class HomeController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private static LoginModel _model = null;
        private LUsuario _usuario;

        public HomeController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IServiceProvider serviceProvider)
        {
            _signInManager = signInManager;
            _usuario = new LUsuario(userManager, signInManager, roleManager);
        }

        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction(nameof(PrincipalController.Principal), "Principal");
            }
            else
            {
                if (_model == null)
                {
                    return View();
                }
                else
                {
                    return View(_model);
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _usuario.UserLoginAsync(model);
                if (result.Succeeded)
                {
                    return Redirect("/Principal/Principal");
                }
                else
                {
                    model.ErrorMessage = "Correo o contraseña inválidos.";
                    _model = model;
                    return Redirect("/");
                }
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode = null)
        {
            ErrorViewModel error = null;
            if (statusCode != null)
            {
                error = new ErrorViewModel
                {
                    RequestId = Convert.ToString(statusCode),
                    ErrorMessage = "Se produjo un error al procesar su solicitud",
                };
            }
            else
            {
                var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
                if (exceptionFeature != null)
                {
                    error = new ErrorViewModel
                    {
                        RequestId = "500",
                        ErrorMessage = exceptionFeature.Error.Message,
                    };
                }
            }
            return View(error);
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            String[] rolesName = { "Admin", "User" };
            foreach (var item in rolesName)
            {
                var roleExist = await roleManager.RoleExistsAsync(item);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));
                }
            }
        }
    }
}
