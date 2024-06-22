using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order
    { 
        public int Id { get; set; }

        public Product Product { get; set; }

        public Client Client { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; private set; } = DateTime.Now;

        public OrderState State { get; private set; } = OrderState.Pendent;

        public Order(Product product, Client client)
        {
            Product = product;
            Client = client;
        }
    }
}
