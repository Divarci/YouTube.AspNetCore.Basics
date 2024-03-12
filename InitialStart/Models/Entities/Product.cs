namespace InitialStart.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool StockStatus { get; set; }
        public int StockLevel { get; set; }
    }
}
