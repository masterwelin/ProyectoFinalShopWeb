﻿namespace Shop.Web.Data.Dtos
{
    public record EmployeesAddDto
    {
        public int? empid { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? title { get; set; }
        public string? titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public DateTime creation_date { get; set; }
        public int? creation_user { get; set; }
        public string? address { get; set; } 
        public string? city { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }


    }
}
