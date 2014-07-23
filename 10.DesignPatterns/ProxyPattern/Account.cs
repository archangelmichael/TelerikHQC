namespace ProxyPattern
{
    using System;

    public class Account : IAccount
    {
        public Account(string name, string password, int id)
        {
            this.UserName = name;
            this.Password = password;
            this.Id = id;
            this.IsLoggedIn = false;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; private set; }

        public void LogIn()
        {
            Console.WriteLine(" User {0} logged in successfully!", this.UserName);
            this.IsLoggedIn = true;
        }

        public void LogOut()
        {
            Console.WriteLine(" User {0} logged out successfully!", this.UserName);
            this.IsLoggedIn = false;
        }

        public void AccountStatus()
        {
            if (this.IsLoggedIn)
            {
                Console.WriteLine(" User {0} is still logged!", this.UserName);
            }
            else
            {
                Console.WriteLine(" User {0} is logged out!", this.UserName);
            }
        }
    }
}
