namespace PostgreSql.API.Models
{
    public class Team : BaseEntity
    {
        public Team()
        {
            Drivers = new List<Driver>();
        }
        public string Name { get; set; } = "";
        public int Yesr { get; set; } = 2023;

        public ICollection<Driver> Drivers { get; set; }

    }
}
