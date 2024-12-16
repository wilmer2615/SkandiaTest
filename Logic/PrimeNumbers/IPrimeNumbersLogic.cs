namespace Logic.PrimeNumbers
{
    public interface IPrimeNumbersLogic
    {
        public Task<IEnumerable<int>> GetPrimeNumbers();
    }
}
