using System;

namespace onlineShopping.DL
{
    public class Customer
    {
        private string username;
        private string password;
        public Customer(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string UserName
        {
            get 
            {
                return username; 
            }
            set 
            {
                username = value; 
            }
        }
        public string PassWord
        {
            get 
            { 
                return password; 
            }
            set 
            { 
                password = value; 
            }
        }
    }
}

