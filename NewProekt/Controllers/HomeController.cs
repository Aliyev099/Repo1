using Microsoft.AspNetCore.Mvc;
using NewProekt.Data;
using NewProekt.Models.Home;
using NewProekt.Models.Reservation;
using NewProekt.ViewModels;

namespace NewProekt.Controllers
{
	public class HomeController : Controller
	{
		private readonly PatoDbContext _context;

		public HomeController(PatoDbContext context)
		{
			_context = context;
		}

	
		


		
		public IActionResult Index()
		{

			HomeViewModel viewModels = new HomeViewModel()
			{
				PatoPlace = _context.PatoPlace.ToList(),
				Customers = _context.Customers.ToList(),
				OurMenu = _context.OurMenus.ToList(),
				WelcomeToPatoPlaces = _context.WelcomeToPatoPlaces.ToList(),
				ItalianRestaurantWelcome = _context.ItalianRestaurantWelcomes.FirstOrDefault(),
				OurVideo=_context.OurVideos.FirstOrDefault(),
				TheBlogs=_context.TheBlogs.ToList(),
				customersSayReviews=_context.customersSayReviews.ToList(),
				SignUp=_context.SignUps.FirstOrDefault(),

			};

			return View(viewModels);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Create(CreateHomeViewModel model)
		{

			if (ModelState.IsValid)
			{


				CreateBooking createBooking = new CreateBooking
				{
					AddedDate = model.AddedDate,
					Date = model.Date,
					Email = model.Email,
					Phone = model.Phone,
					Name = model.Name,
					PeopleCount = model.PeopleCount,

				};
				_context.createBooking.Add(createBooking);
			}
			_context.SaveChanges();
			return View();
		}
	}
}
