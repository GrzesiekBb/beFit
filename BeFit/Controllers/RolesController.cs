using System.Security.Claims;
using System.Threading.Tasks;
using BeFit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeFit.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> MakeMeAdmin()
        {
            
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }

           
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Content("Musisz być zalogowany.");
            }

            
            if (!await _userManager.IsInRoleAsync(user, "Admin"))
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return Content($"Użytkownik {user.Email} ma teraz rolę ADMIN ✅");
        }
    }
}
