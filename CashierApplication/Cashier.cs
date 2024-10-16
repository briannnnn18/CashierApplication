namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        public Cashier(string username, string password, string fullName, string department)
            : base(username, password, fullName, department)
        {
        }
    }
}