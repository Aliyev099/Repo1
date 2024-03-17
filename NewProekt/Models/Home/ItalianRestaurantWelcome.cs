using System.ComponentModel.DataAnnotations;

namespace NewProekt.Models.Home
{
    public class ItalianRestaurantWelcome
    {
        [Key]
        public int Id { get; set; }

        public string Icon { get; set; }

        [MaxLength(100, ErrorMessage = "Maksimum 100 simvol ola biler")]
        public string Tittle { get; set; }

        [MaxLength(100)]
        public string UpTittle { get; set; }

        public string Info { get; set; }
    }
}
