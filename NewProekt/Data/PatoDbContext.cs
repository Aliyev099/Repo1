using Microsoft.EntityFrameworkCore;
using NewProekt.Models.Home;
using NewProekt.Models.Menu;
using NewProekt.Models.Reservation;

namespace NewProekt.Data
{
    public class PatoDbContext : DbContext
	{
		public PatoDbContext(DbContextOptions<PatoDbContext> options) : base(options) { }

		public DbSet<ContactUs> ContactUs { get; set; }

		


		public DbSet<Customers> Customers { get; set; }

		public DbSet<ItalianRestaurantWelcome> ItalianRestaurantWelcomes { get; set; }

		public DbSet<OurMenu> OurMenus { get; set; }

		public DbSet<OurVideo> OurVideos { get; set; }

		public DbSet<PatoPlace> PatoPlace { get; set; }


		public DbSet<WelcomeToPatoPlace> WelcomeToPatoPlaces { get; set; }

        public DbSet<TheBlog> TheBlogs { get; set; }

        public DbSet<CustomersSayReview> customersSayReviews { get; set; }

        public DbSet<SignUp> SignUps { get; set; }

		public DbSet<CreateBooking> createBooking { get; set; }

		//Menu

		public DbSet<Categories> Categories { get; set; }

		public DbSet<Tittles> Tittles { get; set; }

		public DbSet<Lunch> lunch { get; set; }

		public DbSet<Dinner> dinner { get; set; }


		//Reservation

		public DbSet<Reservation> Reservations { get; set; }


		
	}
}
