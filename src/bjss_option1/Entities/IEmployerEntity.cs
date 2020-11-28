using Microsoft.Azure.Cosmos.Table;

namespace bjss_option1.Entities
{
    public interface IEmployerEntity : ITableEntity
    {
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
