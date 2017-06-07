using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace WeatherStation.Controllers
{
    public class AccountController : Controller
    {
        // GET
        public ActionResult Login()
        {
            return View();
        }

        public IActionResult External(string provider)
        {
            var authProperties = new AuthenticationProperties
            {
                RedirectUri = "/home/index"
            };

            return new ChallengeResult(provider, authProperties);
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.Authentication.SignOutAsync("Cookies");

            return RedirectToAction(nameof(Login));
        }
    }
}