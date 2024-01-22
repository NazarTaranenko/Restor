using System.ComponentModel.DataAnnotations;

namespace Restor.Models
{
    public class Employe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Заповніть це поле")]
        public string? Email { get; set; }

    }
}
