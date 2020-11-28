using System;

namespace bjss_option1.Entities
{
    public class PersonalEntity : TableEntity
    {
        public bool Active { get; set; }

        public DateTime DOB { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public string Surname { get; set; }
    }
}
