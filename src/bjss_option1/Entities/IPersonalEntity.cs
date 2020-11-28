using System;
using Microsoft.Azure.Cosmos.Table;

namespace bjss_option1.Entities
{
    public interface IPersonalEntity : ITableEntity
    {
        public bool Active { get; set; }

        public DateTime DOB { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public string Surname { get; set; }
    }
}
