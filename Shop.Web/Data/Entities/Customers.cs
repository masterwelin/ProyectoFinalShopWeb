using Shop.Web.Data.Base;

namespace Shop.Web.Data.Entities
{
    public sealed class Customers : CustomersSuppliersBaseEntity
    {
        public int custid { get; set; }
        public string? email { get; set; }
        public string? fax { get; set; }
    }
}
