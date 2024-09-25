namespace Shop.Web.Data.Base
{
    public abstract class CustomersSuppliersBaseEntity : AuditEntity
    {
        public string? companyname { get; set; }
        public string? contactname { get; set; }
        public string? contacttitle { get; set; }
    }
}
