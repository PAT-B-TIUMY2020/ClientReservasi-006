using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_006
{
    public partial class Login : Form
    {

        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttontLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string kategori = service.Login(username, password);

            if (kategori == "admin")
            {
                Register fm = new Register();
                this.Hide();
                fm.Show();
            }
            else if (kategori == "resepsionis")
            {
                Form1 fm = new Form1();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Username dan PAssword Invalid, Silahkan Hubungi admin.");
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }
        }
    }
}
