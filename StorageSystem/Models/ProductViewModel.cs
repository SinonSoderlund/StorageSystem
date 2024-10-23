namespace StorageSystem.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }

        public ProductViewModel(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
            InventoryValue = price * count;
        }
    }
}
