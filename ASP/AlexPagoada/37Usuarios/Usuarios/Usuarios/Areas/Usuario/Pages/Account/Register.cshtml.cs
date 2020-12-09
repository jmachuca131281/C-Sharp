using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Usuarios.Areas.Usuario.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private static InputModel _input = null;
        public RegisterModel( UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            if (_input != null)
            {
                Input = _input;
            }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required(ErrorMessage = "El campo email es obligatorio.")]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "El campo password es obligatorio.")]
            [DataType(DataType.Password)]
            [Display(Name = "Contrase�a")]
            [StringLength(100, ErrorMessage = "El n�mero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
           
            //[Required]
            public string ErrorMessage { get; set; }
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (await RegisterUserAsync())
            {
                return Redirect("/Principal/Principal?area=Principal");
            }
            else
            {
                return Redirect("/Usuario/Register");
            }
        }
        private async Task<bool> RegisterUserAsync()
        {
            var run = false;
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList();
                if (userList.Count.Equals(0))
                {
                    var user = new IdentityUser
                    {
                        UserName = Input.Email,
                        Email = Input.Email
                    };
                    var result = await _userManager.CreateAsync(user, Input.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "User");
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        run = true;
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            Input = new InputModel
                            {
                                ErrorMessage = item.Description,
                                Email = Input.Email
                            };
                        }
                        _input = Input;
                        run = false;
                    }

                }
                else
                {
                    Input = new InputModel
                    {
                        ErrorMessage = $"El {Input.Email} ya esta registrado",
                        Email = Input.Email
                    };
                    _input = Input;
                    run = false;
                }
            }
            return run;
        }
    }
}
