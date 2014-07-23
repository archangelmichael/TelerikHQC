namespace ProxyPattern
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
                IAccount account = new AccountProxy("Georgi", "kllas23", 3);

                account.AccountStatus();
                account.LogIn();
                // Uncommenting next line will cause UnauthorizedAccessException
                // account.LogIn();
                account.AccountStatus();
                account.LogOut();
                account.AccountStatus();
        }
    }
}
