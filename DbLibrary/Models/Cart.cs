namespace DbLibrary.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Firm { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
