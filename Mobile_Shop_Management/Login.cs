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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "e9ueoA2oNDN3xNesVin6jW1YjWQyzbpOAgMmBhYX",
            BasePath = "https://mobile-shop-5ab04-default-rtdb.firebaseio.com"

        };
        IFirebaseClient client;
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            UsernameTbox.Text = "";
            passTbox.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
                string.IsNullOrWhiteSpace(passTbox.Text))
            {
                MessageBox.Show("please fill all felds");
                return;
            }
            FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
            MyUser ResUser = res.ResultAs<MyUser>();
            MyUser CurUser = new MyUser()
            {
                User = UsernameTbox.Text,
                Password = passTbox.Text
            };
            if(MyUser .IsEqual (ResUser ,CurUser ))
            {
               Home  real = new Home();
                real.ShowDialog();
            }
            else
            {
                MyUser.ShowError();
            }

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Registration_Form reg = new Registration_Form();
            reg.ShowDialog();
        }
    }
    }
    

