using System.ComponentModel.DataAnnotations;

namespace Shop.Models.ViewModels.Requests
{
    public class SignUpRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; } = string.Empty;
    }
}
