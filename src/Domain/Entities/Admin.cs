namespace Domain.Entities
{
    public class Admin : User
    {
        public Admin(string name, string lastName, string password, string email, string userName) : base(name, lastName, password, email, userName)
        {
            
        }
    }
}
