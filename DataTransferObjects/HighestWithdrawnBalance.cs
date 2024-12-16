using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class HighestWithdrawnBalance
    {
        public string Client { get; set; } = null!;
        public decimal WithdrawnBalance { get; set; }
    }
}
