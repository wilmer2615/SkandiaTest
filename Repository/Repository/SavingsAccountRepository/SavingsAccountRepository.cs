using DataTransferObjects;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repository.SavingsAccountRepository
{
    public class SavingsAccountRepository : ISavingsAccountRepository
    {
        private readonly AplicationDbContext _context;

        public SavingsAccountRepository(AplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<AccountMoreHeadlines?>> GetAccountMoreHeadlines()
        {
            return await _context
                .Set<AccountMoreHeadlines>()
                .FromSqlRaw("EXEC dbo.AccountMoreHeadlines")
                .ToListAsync();
        }

        public async Task<IEnumerable<NumberActiveForeignAccounts>> GetActiveForeignAccounts()
        {
            return await _context
                .Set<NumberActiveForeignAccounts>()
                .FromSqlRaw("EXEC dbo.ActiveForeignAccounts")
                .ToListAsync();
        }

        public async Task<IEnumerable<CustomerAccountBalance>> GetCustomerAccountBalance()
        {
            return await _context
                .Set<CustomerAccountBalance>()
                .FromSqlRaw("EXEC dbo.CustomerAccountBalance")
                .ToListAsync();
        }

        public async Task<IEnumerable<HighestBalanceExchange?>> GetHighestBalanceExchange()
        {
            return await _context
                .Set<HighestBalanceExchange>()
                .FromSqlRaw("EXEC dbo.HighestBalanceExchange")
                .ToListAsync();
        }

        public async Task<IEnumerable<HighestWithdrawnBalance?>> GetHighestWithdrawnBalance()
        {
            return await _context
                .Set<HighestWithdrawnBalance>()
                .FromSqlRaw("EXEC dbo.HighestWithdrawnBalance")
                .ToListAsync();
        }
    }
}
