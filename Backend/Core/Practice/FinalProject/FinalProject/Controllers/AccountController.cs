using FinalProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        #region Fields
        // Injecting Identity services:
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
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }
        #endregion

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            // Map user credentials entered with IdentityUser, and create this Identity new user.
            if (ModelState.IsValid) // if model annotation validation passed: =>
            {
                // 1. Create a new Identity user - mapping user credentials with IdentityUser.
                IdentityUser identityUser = new IdentityUser
                {
                    UserName = register.UserName,
                    Email = register.Email,
                    PhoneNumber = register.PhoneNumber
                };

                // 2. Create new identity for the new user
                var identityResult = await _userManager
                    .CreateAsync(identityUser, register.Password);

                // 3. if user registration/IdentityUser was created successfully, do something (in the return statement)
                if (identityResult.Succeeded)
                {
                    // Set a new role for the new registered user in table: AspNetRoles (Add the new registered user to AspNetRoles)
                    await _userManager.AddToRoleAsync(identityUser, "User");

                    // Sign in the user newly registered

                    return RedirectToAction("Login"); // Go to Login View page
                }
                // if registration entry failed
                else
                {
                    // Display error for user in Register View - annotation
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View();
        }
        #endregion

        #region Login
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await _signInManager // Map user credentials to IdentityUser
                    .PasswordSignInAsync(
                        userName: login.UserName,
                        password: login.Password,
                        isPersistent: false,
                        lockoutOnFailure: false);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View();
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
        #endregion
    }

}

