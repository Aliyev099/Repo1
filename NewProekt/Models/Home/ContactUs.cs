using System.ComponentModel.DataAnnotations;

namespace NewProekt.Models.Home
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string Mail { get; set; }
    }
}
