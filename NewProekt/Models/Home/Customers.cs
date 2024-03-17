using System.ComponentModel.DataAnnotations;

namespace NewProekt.Models.Home
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }

        public string Tittle { get; set; }

        public string Uptittle { get; set; }

        public string Icon { get; set; }
    }
}
