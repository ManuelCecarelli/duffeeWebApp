namespace Domain.Entities
{
    public class Client : User
    {
        public ICollection<Order> myPendentOrders { get; set; } = new List<Order>();

        public Client(string name, string lastName, string password, string email, string userName) :base(name, lastName, password, email, userName)
        {
            
        }
    }
}
