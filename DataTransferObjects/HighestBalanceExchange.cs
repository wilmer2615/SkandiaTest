using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class HighestBalanceExchange
    {
        public string Client { get; set; } = null!;
        public decimal BalanceExchange { get; set; }
    }
}
