namespace Shop.Web.Data.Dtos
{
    public class ShippersRemoveDto
    {
        public int shipperid { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }


    }
}
