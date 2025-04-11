namespace Unicorn_Trade_api.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Funds { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
