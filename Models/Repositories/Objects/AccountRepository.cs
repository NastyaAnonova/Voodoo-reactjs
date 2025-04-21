using Microsoft.EntityFrameworkCore;
using Shop.Models.Database;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;

namespace Shop.Models.Repositories.Objects
{
    public class AccountRepository(ApplicationContext context) : IAccountRepository
    {
        private readonly ApplicationContext _context = context;

        public async Task<AccountModel?> CreateAsync(string email, string password, string firstName, string LastName, string phoneNumber, string address)
        {
            if (!await IsNewAsync(email)) return null;

            AccountModel account = new() { Email = email, Password = password, FirstName = firstName, LastName = LastName, PhoneNumber = phoneNumber, Address = address };
            await _context.AddAsync(account);
            await _context.SaveChangesAsync();
            return account;
        }

        public async Task<AccountModel?> GetAsync(string email, string password)
        {
            return await _context.Accounts
                .AsNoTracking()
                .Where(model => model.Email == email && model.Password == password)
                .FirstOrDefaultAsync();
        }

        public async Task<AccountModel?> GetAsync(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<bool> IsNewAsync(string email)
        {
            return !await _context.Accounts
                .AsNoTracking()
                .Where(model => model.Email == email)
                .AnyAsync();
        }
    }
}
