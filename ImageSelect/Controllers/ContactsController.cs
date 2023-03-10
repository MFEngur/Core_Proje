using BussinesLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
	public class ContactsController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());
		public IActionResult Index()
		{
			var values2 = contactManager.TGetList();
			Random rnd = new Random();
			int id = rnd.Next(1, values2.Count);


			var values = contactManager.TGetById(id);
			var values3 = values2[id]; 
			ViewData["path"] = values.Description;
			ViewData["deneme"] = values3.Description;
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
            var values2 = contactManager.TGetList();
           
            Random rnd = new Random();
            int id = rnd.Next(1, values2.Count);
			
		
            var values = contactManager.TGetById(id);
			var values3 = values2[id];
			ViewData["path"] = values.Description;
			ViewData["deneme"] = values3.Description;
			return View();
		}
	}
}
