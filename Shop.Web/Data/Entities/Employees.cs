using Shop.Web.Data.Base;

namespace Shop.Web.Data.Entities
{
    public sealed class Employees : AuditEntity
    {
        public int empid { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? title { get; set; }
        public string? titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        /*public int mgrid { get; set; }*/
        public string? phone { get; set; }
    }
}
