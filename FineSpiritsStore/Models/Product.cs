namespace FineSpiritsStore.Models
{

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }
        public string Country { get; set; }
    }
}
