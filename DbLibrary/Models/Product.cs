namespace DbLibrary.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Firm { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }  
        public int Count { get; set; }
    }
}
