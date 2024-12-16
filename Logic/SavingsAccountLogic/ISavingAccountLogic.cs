using DataTransferObjects;

namespace Logic.SavingsAccountLogic
{
    public interface ISavingAccountLogic
    {
        public Task<IEnumerable<HighestBalanceExchange?>> GetHighestBalanceExchange();
        public Task<IEnumerable<HighestWithdrawnBalance?>> GetHighestWithdrawnBalance();
        public Task<IEnumerable<AccountMoreHeadlines?>> GetAccountMoreHeadlines();
        public Task<IEnumerable<CustomerAccountBalance>> GetCustomerAccountBalance();
        public Task<IEnumerable<NumberActiveForeignAccounts>> GetActiveForeignAccounts();

    }
}
