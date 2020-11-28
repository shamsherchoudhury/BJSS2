namespace bjss_option1.Entities
{
    public class EmployersEntity : TableEntity
    {
        public bool Contracting { get; set; }

        public bool CurrentEmployer { get; set; }

        public string EmployerLocation { get; set; }

        public string EmployerName { get; set; }

        public bool FullTime { get; set; }

        public string Role { get; set; }

        public int Salary { get; set; }

        public bool Temporary { get; set; }
    }
}
