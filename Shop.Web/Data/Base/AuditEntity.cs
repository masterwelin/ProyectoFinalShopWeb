using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;

namespace Shop.Web.Data.Base
{
    public abstract class AuditEntity
    {

        public AuditEntity()
        {

            this.deleted = false;
            this.creation_date = DateTime.Now;

        }

        public DateTime creation_date { get; set; }
        public bool deleted { get; set; }
        public int? creation_user { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; } 
        public string? postalcode { get; set; }
        public string? country { get; set; }

    }
}
