using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class AccountMoreHeadlines
    {
        public Guid AccountNumber { get; set; } 
        public int NumberOfHolders { get; set; }
    }
}
