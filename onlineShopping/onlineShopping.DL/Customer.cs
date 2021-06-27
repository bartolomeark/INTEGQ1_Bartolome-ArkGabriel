using System;
using System.Data.SqlClient;
using onlineShopping;

namespace onlineShopping.DL
{
    public class Customer
    {

        public string username;
        public string password;
        

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

