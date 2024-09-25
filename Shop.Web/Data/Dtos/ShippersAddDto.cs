namespace Shop.Web.Data.Dtos
{
    public class ShippersAddDto
    {
        public string? name {  get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string? country { get; set; }
        public DateTime? creation_date { get; set; }
        public int? Creation_user { get; set;}


    }
}
