using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Usuarios.Library
{
    public class LUsuario: ListObject
    {
        public LUsuario(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
            
        internal async Task<SignInResult> UserLoginAsync(LoginModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Input.Email,
                model.Input.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {

            }

            return result;
        }
    }
}
