using System;
using System.Collections.Generic;
using Desafio_TriMania.Enum;
namespace Desafio_TriMania.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }//identifico o cliente pelo id dele
        public decimal TotalValue { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CancelationDate { get; set; }
        public DateTime? FinishedDate { get; set; }
        public OrderStatus Status { get; set; }
        public List<Product> Products { get; set; }
        public User User { get; set; }
        //public virtual ICollection<Product> Products { get; set;}
        public Order()
        {

        }

        public Order(int orderId, decimal totalValue, DateTime cancelationDate,
        DateTime finishedDate, OrderStatus status)
        {
            
            this.User = new User();
            this.OrderId = orderId;
            this.TotalValue = totalValue;
            this.CreationDate = DateTime.Now;
            this.CancelationDate = cancelationDate;
            this.FinishedDate = finishedDate;
            this.Status = status;
            this.Products = new List<Product>();
            //this.Products = new HashSet<Product>();
        }

    }
}