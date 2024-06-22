using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order
    { 
        public int Id { get; set; }

        public Product RelatedPoduct { get; set; }

        public Client RelatedClient { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; private set; }

        public OrderState State { get; private set; }

        public Order(Product relProduct, Client relClient)
        {
            RelatedPoduct = relProduct;
            RelatedClient = relClient;
            CreationDate = DateTime.Now;
            State = OrderState.Pendent;
        }
    }
}
