using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class FeatureController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
