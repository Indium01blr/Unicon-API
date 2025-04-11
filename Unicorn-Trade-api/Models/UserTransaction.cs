namespace Unicorn_Trade_api.Models
{
    public class UserTransaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StockId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool isBuy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
