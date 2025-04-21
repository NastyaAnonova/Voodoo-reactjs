using System.ComponentModel.DataAnnotations;

namespace Shop.Models.Database.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
