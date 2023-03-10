using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        
        public readonly UserManager<WriterUser> _usermanager;
		public RegisterController(UserManager<WriterUser> userManager)
		{
			_usermanager = userManager;
		}
		[HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterViewModel p)
		{
			WriterUser w = new WriterUser()
			{
				Name = p.Name,
				SurName = p.SurName,
				Email = p.Mail,
				UserName = p.UserName,
				ImageUrl = p.ImageUrl
			};

			if (p.Password == p.ConfirmedPassword)
			{
				var result = await _usermanager.CreateAsync(w, p.Password);

				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}
		//[HttpPost]
		//public async Task< IActionResult> Index(UserRegisterViewModel p)
		//{
		//    if(ModelState.IsValid)
		//    {
		//        WriterUser w = new WriterUser()
		//        {
		//            Name = p.Name,
		//            SurName = p.SurName,
		//            Email = p.Mail,
		//            UserName = p.UserName,
		//            ImageUrl = p.ImageUrl,
		//        };
		//        var result = await _usermanager.CreateAsync(w,p.Password);
		//        if (result.Succeeded)
		//        {
		//            return RedirectToAction("Index", "Login");
		//        }
		//        else
		//        {
		//            foreach( var item in result.Errors )
		//            {
		//                ModelState.AddModelError("",item.Description);
		//            }

		//        }

		//    }
		//    return View(p);
		//}
	}
}
