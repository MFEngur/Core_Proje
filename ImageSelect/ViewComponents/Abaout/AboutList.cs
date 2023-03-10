using BussinesLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Abaout
{
	public class AboutList: ViewComponent
	{
		AboutManager aboutmanager = new AboutManager(new EfAboutDal());

		public IViewComponentResult Invoke()
		{
			var values = aboutmanager.TGetList();

			return View(values);
		}
	}
}
