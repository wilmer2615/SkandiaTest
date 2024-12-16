using DataTransferObjects;
using Repository.Repository.CreditCardRepository;


namespace Logic.CreditCardLogic
{
    public class CreditCardLogic : ICreditCardLogic
    {
        private readonly ICreditCardRepository _creditCardRepository;

        public CreditCardLogic(ICreditCardRepository creditCardRepository)
        {
            this._creditCardRepository = creditCardRepository;
        }
        public async Task<IEnumerable<FranchiseDebt>> GetFranchiseDebts()
        {
            return await this._creditCardRepository.GetFranchiseDebts();
        }

        public async Task<IEnumerable<CustomerAccountBalance>> GetTotalDebtBalanceShareholders()
        {
            return await this._creditCardRepository.GetTotalDebtBalanceShareholders();
        }
    }
}
