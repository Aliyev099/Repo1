using System.ComponentModel.DataAnnotations;

namespace NewProekt.ViewModels
{
	public class CreateReservationViewModel
	{
        public DateTime Date { get; set; }

        public DateTime AddedDate { get; set; }

        public int PeopleCount { get; set; }

        [MaxLength(10,ErrorMessage ="Maksimum 10 simvol ola biler")]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
