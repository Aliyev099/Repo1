using Microsoft.AspNetCore.Mvc;
using NewProekt.Data;
using NewProekt.Models.Reservation;
using NewProekt.ViewModels;

namespace NewProekt.Controllers
{
	public class ReservationController : Controller
	{
		private readonly PatoDbContext _context;

		public ReservationController(PatoDbContext patoDbContext)
		{
			_context = patoDbContext;
		}


		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Index(CreateReservationViewModel model)
		{

			if (ModelState.IsValid)
			{


				Reservation rezervasiya = new Reservation
				{
					AddedDate = model.AddedDate,
					Date = model.Date,
					Email = model.Email,
					Phone = model.Phone,
					Name = model.Name,
					PeopleCount = model.PeopleCount,

				};
				_context.Reservations.Add(rezervasiya);
			}
			_context.SaveChanges();
			return View();
		}

		
	}
}
