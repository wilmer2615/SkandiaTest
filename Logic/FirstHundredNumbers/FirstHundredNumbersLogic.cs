using DataTransferObjects;

namespace Logic.FirstHundredNumbers
{
    public class FirstHundredNumbersLogic : IFirstHundredNumbersLogic
    {
        public Task<IEnumerable<NumbersResultDto>> GetFirtsHundredNumbers()
        {
            List<NumbersResultDto> result = new List<NumbersResultDto>();

            for (int i = 1; i <= 100; i++)
            {
                NumbersResultDto numbersResult = new NumbersResultDto();
                numbersResult.Number = i;

                if (i % 3 == 0 && i % 5 == 0)
                {
                    numbersResult.Description = "Bingo!";
                }
                else if (i % 3 == 0)
                {
                    numbersResult.Description = "Bin";
                }
                else if (i % 5 == 0)
                {
                    numbersResult.Description = "Go";
                }

                result.Add(numbersResult);
            }

            return Task.FromResult<IEnumerable<NumbersResultDto>>(result);
        }

    }
}
