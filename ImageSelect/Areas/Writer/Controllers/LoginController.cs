﻿using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class LoginController : Controller
	{
		private readonly SignInManager<WriterUser> _signInManager;

		public LoginController(SignInManager<WriterUser> signInManager)
		{
			_signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		

		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel p) 
		{ 
		if(ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName,p.Password,true,true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Default");
				}
				else
				{
					ModelState.AddModelError("", "Hatalı Kullanıcı adı veya şifre hatalı");
				}
				
			}
			return View();
		}
	}
}
