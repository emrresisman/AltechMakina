using Microsoft.AspNetCore.Mvc;

namespace AltechMakina.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult KVKK()
        {
            return View();
        }


    }
}
