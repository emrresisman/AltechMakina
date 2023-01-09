using Microsoft.AspNetCore.Mvc;

namespace AltechMakina.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Media()
        {
            return View();
        }
    }
}
