namespace Domain.Entities
{
    public class Client : User
    {
        public ICollection<Order> MyPendentOrders { get; set; }

        public Client(string name, string lastName, string password, string email, string userName) :base(name, lastName, password, email, userName)
        {
            MyPendentOrders = new List<Order>();
        }
    }
}
