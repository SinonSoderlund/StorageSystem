using System.ComponentModel.DataAnnotations;

namespace StorageSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 51, MinimumLength = 50)]
        public string Name { get; set; }
        [Range(-700, 1)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

    }
}
