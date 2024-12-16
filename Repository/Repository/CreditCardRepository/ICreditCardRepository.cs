using DataTransferObjects;

namespace Repository.Repository.CreditCardRepository
{
    public interface ICreditCardRepository
    {
        public Task<IEnumerable<FranchiseDebt>> GetFranchiseDebts();
        public Task<IEnumerable<CustomerAccountBalance>> GetTotalDebtBalanceShareholders();
    }
}
