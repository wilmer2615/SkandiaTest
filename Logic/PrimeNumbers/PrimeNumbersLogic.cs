namespace Logic.PrimeNumbers
{
    public class PrimeNumbersLogic : IPrimeNumbersLogic
    {
        public Task<IEnumerable<int>> GetPrimeNumbers()
        {
            List<int> result = new List<int>();
            
            for (int i = 2; result.Count < 50; i++)
            {
                bool isPrime = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0) 
                    {
                        isPrime = false;
                        break; 
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return Task.FromResult<IEnumerable<int>>(result);
        }
    }
}
