using HumanResourcesApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourcesApp.Controllers
{
    public class AccountController : Controller
    {
        #region Fields
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        #endregion

        #region Constructors
        public AccountController
            (
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            // Map each manager to its property in ViewModel
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        #endregion

        #region Action methods
        #region Register    
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                IdentityUser identityUser = new IdentityUser
                {
                    UserName = register.Username,
                    Email = register.Email,
                    PhoneNumber = register.PhoneNumber
                };
                var identityResult = await _userManager.CreateAsync(identityUser, register.Password);

                if (identityResult.Succeeded)
                {
                    await _userManager.AddToRoleAsync(identityUser, "User");  // 2nd arguement is the role that we enter in DB under Name column
                    // in table ASPNETROLES table.
                    return RedirectToAction("Login");  // Login is not yet implememented
                }
                else
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View();
        }
        #endregion

        public async Task<IActionResult> RegisterPractice(RegisterViewModel register)
        {
            // Create a new IdentityUser
            IdentityUser identityUser = new IdentityUser
            {
                UserName = register.Username,
                Email = register.Email,
                PhoneNumber = register.PhoneNumber
            };

            var identityResult = await _userManager.CreateAsync(identityUser, register.Password);

            if (identityResult.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return View();
        }

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    userName: login.Username,
                    password: login.Password,
                    isPersistent: false,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    // ModelState.AddModelError("Username", "Invalid username");
                    // ModelState.AddModelError("Password", "Invalid password.");
                    return View(login);
                }

            }
            return View(login);
        }
        #endregion

        #region Logout
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        #endregion

        #endregion

        #region Update Account Info
        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            var userIdentity = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userIdentity != null)
            {
                var managerUser = new ManageUser
                {
                    Id = userIdentity.Id,
                    Email = userIdentity.Email,
                    PhoneNumber = userIdentity.PhoneNumber
                };
                return View(managerUser);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Manage(ManageUser manageUser)
        {
            var userIdentity = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userIdentity == null)
            {
                return NotFound();
            }
            userIdentity.Email = manageUser.Email;
            userIdentity.PhoneNumber = manageUser.PhoneNumber;

            await _userManager.UpdateAsync(userIdentity);

            return View("Index", "Home");
        }
        #endregion
    }
}

