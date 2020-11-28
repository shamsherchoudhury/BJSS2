using System;

namespace bjss_option1.Models
{
    public class Employer
    {
        private Guid _id;

        public bool Contracting { get; set; }

        public bool CurrentEmployer { get; set; }

        public string EmployerLocation { get; set; }

        public string EmployerName { get; set; }

        public bool FullTime { get; set; }

        public string Role { get; set; }

        public double Salary { get; set; }

        public bool Temporary { get; set; }
    }
}
