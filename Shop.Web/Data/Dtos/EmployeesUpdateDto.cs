namespace Shop.Web.Data.Dtos
{
    public class EmployeesUpdateDto
    {
        public int empid { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? title { get; set; }
        public string? titlecoutesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        
    }
}
