using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class NumberActiveForeignAccounts
    {
        public int ActiveForeignAccounts { get; set; }
    }
}
