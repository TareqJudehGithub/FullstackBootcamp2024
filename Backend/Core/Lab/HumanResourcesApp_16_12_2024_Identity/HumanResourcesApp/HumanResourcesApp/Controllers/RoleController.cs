using HumanResourcesApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesApp.Controllers
{
    public class RoleController : Controller
    {
        #region Fields
        private RoleManager<IdentityRole> _roleManager;
        #endregion

        #region Constructors
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this._roleManager = roleManager;
        }

        #endregion

        #region Action Roles
        public IActionResult Index()
        {
            var roles = _roleManager.Roles
                .Select(role => new RoleViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                }).ToList();

            return View(roles);
        }

        public async Task<IActionResult> Create(RoleViewModel role)
        {
            // maps Identity role to its ViewModel
            var identityRole = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = role.RoleName,
                NormalizedName = role.RoleName.ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            // Creates the role:
            await _roleManager.CreateAsync(identityRole);

            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
