
using UserAccountNamespace;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        public Cashier(string username, string password, string fullName, string department)
            : base(username, password, fullName, department)
        {
        }

        public bool Login(string username, string password)
        {
            return ValidateCredentials(username, password);
        }

        private bool ValidateCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }

        internal class UserAccountNamespace
        {
        }
    }
}
