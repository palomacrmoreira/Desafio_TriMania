namespace Desafio_TriMania.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }

        public Item()
        {

        }

        public Item(int itemId, decimal price, int quantity, string name)
        {
            this.ItemId = itemId;
            this.Price  = price;
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}