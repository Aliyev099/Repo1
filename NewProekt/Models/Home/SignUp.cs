using System.ComponentModel.DataAnnotations;

namespace NewProekt.Models.Home
{
    public class SignUp
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100, ErrorMessage = "Maksimum 100 simvol ola biler")]
        public string Tittle { get; set; }

        [MaxLength(100)]
        public string UpTittle { get; set; }
    }
}
