using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class CustomerAccountBalance
    {
        public string Client { get; set; } = null!;
        public decimal TotalBalance { get; set; }
    }
}
