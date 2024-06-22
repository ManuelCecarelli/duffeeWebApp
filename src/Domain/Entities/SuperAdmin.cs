namespace Domain.Entities
{
    public class SuperAdmin : User
    {
        public SuperAdmin(string name, string lastName, string password, string email, string userName) : base(name, lastName, password, email, userName)
        {
            
        }
    }
}
