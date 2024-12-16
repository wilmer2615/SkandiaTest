using DataTransferObjects;

namespace Logic.FirstHundredNumbers
{
    public interface IFirstHundredNumbersLogic
    {
        public Task<IEnumerable<NumbersResultDto>> GetFirtsHundredNumbers();

    }
}
