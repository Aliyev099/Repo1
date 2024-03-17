using Microsoft.AspNetCore.Mvc;
using NewProekt.Data;
using NewProekt.Models.Menu;
using NewProekt.Models.Reservation;
using NewProekt.ViewModels;
using System.Reflection.Metadata.Ecma335;

namespace NewProekt.Controllers
{
	public class MenuController : Controller
	{
		private readonly PatoDbContext _context;

		public MenuController(PatoDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			MenuViewModel viewModel = new MenuViewModel()
			{
				Categories = _context.Categories.ToList(),
				Tittles = _context.Tittles.ToList(),
				lunch = _context.lunch.ToList(),
				dinner = _context.dinner.ToList(),
			};
			return View(viewModel);


		}

	}
}
