using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;
using Shop.Models.ViewModels.Requests;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Shop.Controllers
{
    public class AuthController(IAccountRepository accountRepository) : Controller
    {
        private readonly IAccountRepository _accountRepository = accountRepository;

        [HttpGet("/login")]
        public IActionResult Login()
        {
            if (HttpContext.User.Claims.Any())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> LoginPost(LoginRequest login)
        {
            if (!ModelState.IsValid) return new BadRequestResult();

            AccountModel? account = await _accountRepository.GetAsync(login.Email, login.Password);

            if (account == null) return new UnauthorizedResult();

            List<Claim> claims = [new Claim(ClaimTypes.Name, account.Id.ToString())];
            ClaimsIdentity claimsIdentity = new(claims, "Cookies");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return new OkResult();
        }

        [HttpGet("/signup")]
        public IActionResult SignUp()
        {
            if (HttpContext.User.Claims.Any())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost("/signup")]
        public async Task<IActionResult> SignUpPostAsync(SignUpRequest signUp)
        {
            if (!ModelState.IsValid) return new BadRequestResult();

            AccountModel? account = await _accountRepository.CreateAsync(signUp.Email, signUp.Password, signUp.FirstName, signUp.LastName, signUp.PhoneNumber, signUp.Address);

            if (account == null) return new UnauthorizedResult();

            List<Claim> claims = [new Claim(ClaimTypes.Name, account.Id.ToString())];
            ClaimsIdentity claimsIdentity = new(claims, "Cookies");
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return new OkResult();
        }

        [Authorize]
        [HttpPost("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return new OkResult();
        }
    }
}
