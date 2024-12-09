using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace InventoryManagementDemo.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly UserManager<StudentAccount> _userManager;
        private readonly ILogger<StudentController> _logger;

        public StudentController(UserManager<StudentAccount> userManager, ILogger<StudentController> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAccount(string userId, string fullName, string password, string confirmPassword, uint pageLeft)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                _logger.LogError("notfound");
                return NotFound();
            }

            // Update Full Name
            if (!string.IsNullOrEmpty(fullName))
            {
                user.FullName = fullName;
            }

            user.PageLeft += pageLeft;

            // Update Password (if provided)
            if (!string.IsNullOrEmpty(password) && password == confirmPassword)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, password);
                if (!result.Succeeded)
                {
                    // Handle password reset errors
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View("Account", user); // Assuming "Account" is your view name
                }
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                // Handle user update errors
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View("Account", user); // Assuming "Account" is your view name
            }

            return RedirectToAction("Account"); // Redirect to the account page
        }

        public IActionResult Account()
        {
            return View();
        }

        public IActionResult PrintHistory()
        {
            return View();
        }

        public IActionResult BuyPage()
        {
            return View();
        }

        public IActionResult StartPrint()
        {
            return View();
        }

        public IActionResult PageConfig()
        {
            return View();
        }

        public IActionResult Stats()
        {
            return View();
        }
        public IActionResult Hidden()
        {
            return View();
        }
    }
}