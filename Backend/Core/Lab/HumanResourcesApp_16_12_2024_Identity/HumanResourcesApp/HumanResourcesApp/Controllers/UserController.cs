//using HumanResourcesApp.ViewModels;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace HumanResourcesApp.Controllers
//{
//    public class UserController : Controller
//    {

//        private UserManager<IdentityUser> _userManager;
//        private SignInManager<IdentityUser> _signInManager;
//        private RoleManager<IdentityRole> _roleManager;

//        public UserController
//            (
//            UserManager<IdentityUser> userManager,
//            SignInManager<IdentityUser> signInManager,
//            RoleManager<IdentityRole> roleManager
//            )

//        {
//            // Map each manager to its property in ViewModel
//            this._userManager = userManager;
//            this._signInManager = signInManager;
//            this._roleManager = roleManager;
//        }


//        public async Task<IActionResult> Index()
//        {
//            // get all users
//            var user = await _userManager.Users
//               .Select(user => new UserManageViewModel
//               {
//                   Id = user.Id,
//                   UserName = user.UserName,
//                   Email = user.Email,
//                   Roles = _userManager.GetRolesAsync(user).Result
//               }).ToListAsync();

//            return View();
//        }

//        [HttpGet]
//        public async Task<IActionResult> Manage(string id)
//        {
//            var user = await _userManager.FindByIdAsync(id);

//            if (user == null)
//                return NotFound();

//            var roles = await _roleManager.Roles.ToListAsync();

//            var viewModel = new UserManageViewModel
//            {
//                Id = user.Id,
//                UserName = user.UserName,
//                Roles = roles.Select(x => new CheckBoxViewModel
//                {
//                    Id = x.Id,
//                    Name = x.Name,
//                    IsSelected = _userManager.IsInRoleAsync(user, x.Name).Result
//                }).ToList()
//            };

//            return View(viewModel);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Manage(UserManageViewModel model)
//        {
//            var user = await _userManager.FindByIdAsync(model.Id);
//            var rolesToRemove = await _userManager.GetRolesAsync(user);
//            var responseGet = await _userManager
//                .RemoveFromRolesAsync(user, rolesToRemove);

//            if (responseGet.Succeeded)
//            {
//                var rolesToAdd = model.Roles
//                    .Where(x => x.IsSelected)
//                    .Select(x => x.Name).ToList();

//                var res = await _userManager.AddToRolesAsync(user, rolesToAdd);
//            }
//            return RedirectToAction(nameof(Index));
//        }


//    }
//}
