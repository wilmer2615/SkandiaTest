using Microsoft.EntityFrameworkCore;

namespace DataTransferObjects
{
    [Keyless]
    public class FranchiseDebt
    {
        public string FranchiseDescription { get; set; } = null!;
        public decimal TotalDeuda { get; set; }
    }
}
