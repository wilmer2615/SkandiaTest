using DataTransferObjects;

namespace Logic.CreditCardLogic
{
    public interface ICreditCardLogic
    {
        public Task<IEnumerable<FranchiseDebt>> GetFranchiseDebts();
        public Task<IEnumerable<CustomerAccountBalance>> GetTotalDebtBalanceShareholders();
    }
}
