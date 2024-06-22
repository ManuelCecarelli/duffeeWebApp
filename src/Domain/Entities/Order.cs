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
        public DateTime CreationDate { get; private set; }

        public OrderState State { get; private set; }

        public Order(Product product, Client client)
        {
            Product = product;
            Client = client;
            CreationDate = DateTime.Now;
            State = OrderState.Pendent;
        }
    }
}
