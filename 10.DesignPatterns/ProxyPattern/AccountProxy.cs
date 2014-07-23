using System;
using System.Linq;

namespace ProxyPattern
{
    public class AccountProxy :  IAccount
    {
        private const int EmployeeCount = 21;

        public AccountProxy(string userName, string password, int id)
        {
            if (id < EmployeeCount)
            {
                this.RealAccount = new Account(userName, password, id);
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid Id hacker!");
            }
        }
        
        private Account RealAccount { get; set; }

        public void LogIn()
        {
            if (!CheckIfAccountIsActive())
            {
                this.RealAccount.LogIn();
            }
            else
            {
                throw new UnauthorizedAccessException("User is logged hacker!");
            }
        }

        public void LogOut()
        {
            this.RealAccount.LogOut();
        }

        public void AccountStatus()
        {
            this.RealAccount.AccountStatus();
        }

        private bool CheckIfAccountIsActive()
        {
            if (this.RealAccount.IsLoggedIn)
            {
                return true;
            }

            return false;
        }
    }
}
