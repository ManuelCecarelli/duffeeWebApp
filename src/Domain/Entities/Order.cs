using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order
    { 
        public int Id { get; set; }

        public Product RelatedProduct { get; set; }

        public Client RelatedClient { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; private set; }

        public OrderState State { get; private set; }

        public Order()
        {
            
        }

        public Order(Product product, Client client)
        {
            RelatedProduct = product;
            RelatedClient = client;
            CreationDate = DateTime.Now;
            State = OrderState.Pendent;
        }
    }
}
