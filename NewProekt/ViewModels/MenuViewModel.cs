using NewProekt.Models.Menu;
using System.ComponentModel.DataAnnotations;

namespace NewProekt.ViewModels
{
	public class MenuViewModel
	{
        public List<Categories> Categories { get; set; }

		public List<Tittles> Tittles { get; set; }

		public List<Lunch> lunch { get; set; }

		public List<Dinner> dinner { get; set; }

		
	}

}
