using BussinesLayer.Concreate;
using BussinesLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace Core_Proje.Controllers
{
	public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal()); 
		public IActionResult Index()
		{
            ViewBag.v1 = "Portföy Listesi";
            ViewBag.v2 = "Portföyüm";
            ViewBag.v3 = "Portföy Listesi ";
            var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
            ViewBag.v1 = "Portföy Listesi";
            ViewBag.v2 = "Portföyüm";
            ViewBag.v3 = "Portföy Ekleme ";
            return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
            PorfolioValidator validations= new PorfolioValidator();
			ValidationResult result= validations.Validate(portfolio);
			if (result.IsValid)
			{
                portfolioManager.TAdd(portfolio);
                return RedirectToAction("Index");
            }
			else
			{
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           
            return View();
			
		}
	
		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetById(id);
			portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
		[HttpGet]
		public IActionResult UpdatePorfolio(int id)
		{
            ViewBag.v1 = "Portföy Listesi";
            ViewBag.v2 = "Portföyüm";
            ViewBag.v3 = "Portföy Güncelleme ";
			var values = portfolioManager.TGetById(id);
			return View(values);

        }
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio) {
			portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
    }
}
