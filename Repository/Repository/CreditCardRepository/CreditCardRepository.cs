using DataTransferObjects;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repository.CreditCardRepository
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly AplicationDbContext _context;

        public CreditCardRepository(AplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<FranchiseDebt>> GetFranchiseDebts()
        {
            return await _context
                .Set<FranchiseDebt>()
                .FromSqlRaw("EXEC dbo.FranchiseDebt") 
                .ToListAsync();
        }

        public async Task<IEnumerable<CustomerAccountBalance>> GetTotalDebtBalanceShareholders()
        {
            return await _context
                .Set<CustomerAccountBalance>()
                .FromSqlRaw("EXEC dbo.TotalDebtBalanceShareholders")
                .ToListAsync();
        }
    }
}
