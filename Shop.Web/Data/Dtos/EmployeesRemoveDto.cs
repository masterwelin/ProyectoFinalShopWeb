namespace Shop.Web.Data.Dtos
{
    public record EmployeesRemoveDto
    {
        public int empid { get; set; }
        public bool deleted { get; set; }
        public DateTime delete_date { get; set; }
        public int delete_user { get; set; }
    }
}
