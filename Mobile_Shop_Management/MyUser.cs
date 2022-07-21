using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Shop_Management
{
     class MyUser
    {
        
        public string User{ get; set; }
        public string Password { get; set; }

        private static string error = "thee was some error";
        public static void ShowError()
        {
            System .Windows .Forms.MessageBox.Show(error);
        }
        public static bool IsEqual(MyUser user1, MyUser user2)
        {
            if(user1 == null && user2 == null) { return false; }
            if(user1.User != user2.User)
            {
                error = "Username does not exist";
                return false;
            }
            else if(user1.Password != user2.Password)
            {
                error = "Username and password does not exist";
                return false;
            }
            return true;
        }

    }
}
