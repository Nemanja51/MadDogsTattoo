using Microsoft.AspNetCore.Mvc;

namespace MadDogsTattoo.Controllers
{
    public class VladaGalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
