using Shop.Models.Database.Models;

namespace Shop.Models.Repositories.Abstract
{
    public interface IAccountRepository
    {
        public Task<AccountModel?> CreateAsync(string email, string password, string firstName, string LastName, string phoneNumber, string address);

        public Task<AccountModel?> GetAsync(string email, string password);

        public Task<AccountModel?> GetAsync(int id);

        public Task<bool> IsNewAsync(string email);
    }
}
