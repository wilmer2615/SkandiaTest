namespace Entities
{
    public class ShareholdingComposition
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ShareholderId { get; set; }
        public decimal percentage { get; set; }
        public LegalPerson Company { get; set; } = null!;

        public NaturalPerson? ShareholderNatural { get; set; }
        public LegalPerson? ShareholderLegal { get; set; }
    }
}
