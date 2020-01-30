using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace MineData
{
    public partial class registerForm : Form
    {
        private LoginForm parent;
        public registerForm()
        {
            InitializeComponent();
        }

        public registerForm(LoginForm f)
        {
            InitializeComponent();
            parent = f;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textUsername.TextLength < 1)
            {
                MessageBox.Show("Enter username");
                return;
            }
            if (textPass1.TextLength < 1 || textPass2.TextLength < 1)
            {
                MessageBox.Show("Enter password");
                return;
            }
            else
            {
                if(textPass1.Text!=textPass2.Text)
                {
                    MessageBox.Show("Passwords does not match");
                    return;
                }
            }
            if(!cbScietist.Checked && !cbUser.Checked)
            {
                MessageBox.Show("Pick a role");
                return;
            }


            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var topicCollecion = database.GetCollection<User>("User");

            string type="user";
            if (cbScietist.Checked)
                type = "scientist";


            User u = new User { username = textUsername.Text, password=textPass1.Text, type=type };
            topicCollecion.Insert<User>(u);

            parent.enableBtn();
            this.Close();
        }

        private void cbScietist_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScietist.Checked)
                cbUser.Checked = false;
        }

        private void cbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUser.Checked)
                cbScietist.Checked = false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            parent.enableBtn();
            this.Close();
        }
    }
}
