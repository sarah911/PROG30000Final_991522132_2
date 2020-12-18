using LoginClient_991522132.TourService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClient_991522132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TourService.AuthenticateUserServiceClient client = new TourService.AuthenticateUserServiceClient("NetTcpBinding_IAuthenticateUserService");
            User user = new User();
            user.UserName = textBox1.Text;
            user.Password = textBox2.Text;

            label3.Text = client.Login(user);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
