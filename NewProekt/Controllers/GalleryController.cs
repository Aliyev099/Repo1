﻿using Microsoft.AspNetCore.Mvc;

namespace NewProekt.Controllers
{
	public class GalleryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
