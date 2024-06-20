namespace Domain.Entities
{
    public class Client : User
    {
        public ICollection<Order> myPendentOrders { get; set; }
    }
}
