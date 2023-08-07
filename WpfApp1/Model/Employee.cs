using System;

namespace WpfApp1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal? Salary { get; set; }
        public DateTime? Date_of_employment { get; set; }
        public DateTime? Date_of_dismissal { get; set; }

    }
}
