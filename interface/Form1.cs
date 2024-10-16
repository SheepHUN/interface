using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        dbHandler db;
        public Form1()
        {
            InitializeComponent();
            Form2 asd = new Form2();
            asd.ShowDialog();
            this.Hide();
           
            //Start();
        }
        void Start() {
            db = new dbHandler();
            db.ReadAll();
            passwordtb.PasswordChar = '*';
            loginbtn.Click += LoginEvent;
            registerbtn.Click += RegisterEvent;
        }
        void LoginEvent(object s, EventArgs e) {
            foreach (User item in User.allUser) {
                if (usernametb.Text == item.username && passwordtb.Text == item.password) {
                    MessageBox.Show("Sikeres bejelentkezés");
                }
            }
        }
        void RegisterEvent(object s, EventArgs e)
        {

        }
    }
    public class User
    {
        public static List<User> allUser = new List<User>();
        public string username { get; set; }
        public string password { get; set; }

        public int points { get; set; }
        public int id { get; set; }
    }
}
