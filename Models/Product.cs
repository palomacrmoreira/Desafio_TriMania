namespace Desafio_TriMania.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        //public int OrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        //public Order Order { get; set; }

        public Product()
        {

        }

        public Product(int productId, string name, decimal price, int availableQantity,
        int orderId, Order order, string description)
        {
            //this.Order = order;
            this.Description = description;
            this.ProductId = productId;
            //this.OrderId = orderId;
            this.Price = price;
            this.Name = name;
            this.AvailableQuantity = availableQantity;

        }

    }
}