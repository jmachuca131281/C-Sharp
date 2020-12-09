using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace Usuarios.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {  
        public void OnGet()
        {
        }

        [BindProperty]
        public InputModel Input { get; set; }


        public class InputModel
        {
            [Required(ErrorMessage = "El email es obligatorio")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required (ErrorMessage = "El password es obligatorio")]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            [StringLength(100, ErrorMessage = "El número del caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage ="The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string ErrorMessage { get; set; }

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            return Page();
        }


    }
}
