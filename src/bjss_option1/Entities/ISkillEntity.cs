using Microsoft.Azure.Cosmos.Table;

namespace bjss_option1.Entities
{
    public interface ISkillEntity : ITableEntity
    {
        public string Description { get; set; }

        public double LengthOfExperience { get; set; }

        public string Name { get; set; }
    }
}
