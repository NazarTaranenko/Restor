using System.ComponentModel.DataAnnotations;

namespace Restor.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? Name { get; set; }
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? Adress { get; set; }

        public int? Id_Meal { get; set; }
    }
}
