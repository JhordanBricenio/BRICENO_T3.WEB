using APELLIDO_T3.WEB.Repositorio;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BRICEÑO_T3.WEB.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAuthRepositorio _authRepository;


        public AuthController(IAuthRepositorio authRepository)
        {
            this._authRepository = authRepository;
        }

        // GET: AuthController
        public ActionResult Login()
        {
            return View("FormLogin");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Usuario user = new Usuario();
           // password = DesEncriptar(password);


            if (_authRepository.aunteticacionCokie(username, password))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, username)


                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal,
                            new AuthenticationProperties { ExpiresUtc = DateTime.Now.AddDays(1), IsPersistent = true });
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("AuthError", "Usuario o contraseña incorrectos");

            return View("FormLogin");
        }



        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "home");
        }



    }
}
