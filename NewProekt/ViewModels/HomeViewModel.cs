using NewProekt.Models.Home;
using System.ComponentModel.DataAnnotations;

namespace NewProekt.ViewModels
{
    public class HomeViewModel
	{
		public List<Customers> Customers { get; set; }

		public List<PatoPlace> PatoPlace { get; set; }



		public List<OurMenu> OurMenu { get; set; }

        public OurVideo? OurVideo { get; set; }

        public List<ContactUs> ContactUs { get; set; }

		public List<WelcomeToPatoPlace>? WelcomeToPatoPlaces { get; set; }

		public ItalianRestaurantWelcome? ItalianRestaurantWelcome { get; set; }

        public List<TheBlog> TheBlogs { get; set; }

      
       
		
        public List<CustomersSayReview> customersSayReviews { get; set; }

		public SignUp? SignUp { get; set; }


		
	}
}
