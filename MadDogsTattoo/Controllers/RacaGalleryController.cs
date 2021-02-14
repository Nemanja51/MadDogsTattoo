using Microsoft.AspNetCore.Mvc;

namespace MadDogsTattoo.Controllers
{
    public class RacaGalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
