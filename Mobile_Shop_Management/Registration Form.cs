using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Mobile_Shop_Management
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "e9ueoA2oNDN3xNesVin6jW1YjWQyzbpOAgMmBhYX",
            BasePath = "https://mobile-shop-5ab04-default-rtdb.firebaseio.com"

        };
        IFirebaseClient client;
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
                string.IsNullOrWhiteSpace(passTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }


            MyUser user = new MyUser()
            {
                User = UsernameTbox.Text,
                Password = passTbox.Text

            };

            string use = UsernameTbox.Text.Replace("abc", "123");
            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text , user  );
            MessageBox.Show("Successfully registered!");


        }
    }
}
