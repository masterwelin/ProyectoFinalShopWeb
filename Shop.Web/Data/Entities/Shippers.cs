using Shop.Web.Data.Base;

namespace Shop.Web.Data.Entities
{
    public sealed class Shippers : AuditEntity
    {
        public int shipperid { get; set; }
        public int name { get; set; }
        public int phone { get; set; }
    }
}
