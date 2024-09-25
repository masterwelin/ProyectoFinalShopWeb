using Shop.Web.Data.Base;

namespace Shop.Web.Data.Entities
{
    public sealed class Suppliers : CustomersSuppliersBaseEntity
    {
        public int supplierid { get; set; }
        public string? name { get; set; }
        public string? phone { get; set; }
    }
}
