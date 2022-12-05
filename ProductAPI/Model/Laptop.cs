namespace ProductAPI.Model
{
    public class Laptop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public int Ram { get; set; }
        public string CPU { get; set; }
        public int HardDrive { get; set; }
    }
}
