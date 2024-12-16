using DataTransferObjects;
using Repository.Repository.SavingsAccountRepository;

namespace Logic.SavingsAccountLogic
{
    public class SavingAccountLogic : ISavingAccountLogic
    {
        private readonly ISavingsAccountRepository _savingsAccountRepository;

        public SavingAccountLogic(ISavingsAccountRepository savingsAccountRepository)
        {
            this._savingsAccountRepository = savingsAccountRepository;
        }

        public async Task<IEnumerable<AccountMoreHeadlines?>> GetAccountMoreHeadlines()
        {
            return await this._savingsAccountRepository.GetAccountMoreHeadlines();
        }

        public async Task<IEnumerable<NumberActiveForeignAccounts>> GetActiveForeignAccounts()
        {
            return await this._savingsAccountRepository.GetActiveForeignAccounts();
        }

        public async Task<IEnumerable<CustomerAccountBalance>> GetCustomerAccountBalance()
        {
            return await this._savingsAccountRepository.GetCustomerAccountBalance();
        }

        public async Task<IEnumerable<HighestBalanceExchange?>> GetHighestBalanceExchange()
        {
            return await this._savingsAccountRepository.GetHighestBalanceExchange();
        }

        public async Task<IEnumerable<HighestWithdrawnBalance?>> GetHighestWithdrawnBalance()
        {
            return await this._savingsAccountRepository.GetHighestWithdrawnBalance();
        }
    }
}
