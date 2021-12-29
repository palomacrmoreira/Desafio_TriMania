using System.Collections.Generic;
namespace Desafio_TriMania.Models
{
    public class Basket
    {
        public int BasketId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Item> Items { get; set; }
        public decimal TotalValue { get; set; }

        public Basket()
        {

        }
        public Basket(int basketId, int userId, decimal totalValue,
        List<Item> items, User user)
        {
            this.BasketId = basketId;
            this.UserId = userId;
            this.User = user;
            this.Items = default;
        }

    }

}