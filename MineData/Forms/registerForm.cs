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
using MongoDB.Driver.Builders;
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
            getUniversities();
        }

        public void getUniversities()
        {
            MongoDatabase database = MongoService.getDatabase();

            var collecion = database.GetCollection<University>("University");


            comboUniversity.Items.Clear();
            foreach (University u in collecion.FindAll())
            {
                comboUniversity.Items.Add(u.Name);
            }
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


            MongoDatabase database = MongoService.getDatabase();

            var topicCollecion = database.GetCollection<User>("User");
            var universityCollection = database.GetCollection<University>("University");

            var queryUser = from User in topicCollecion.AsQueryable()
                        where User.username == textUsername.Text
                        select User;

            if (queryUser.Count() > 0)
            {
                MessageBox.Show("That username already exists");
                textUsername.Text = "";
                return;
            }

            User u;
            if (cbScietist.Checked)
            {

                var query = from University in universityCollection.AsQueryable<University>()
                            where University.Name == comboUniversity.SelectedItem.ToString()
                            select University;

                University uni = query.First();




                u = new Scientist
                {
                    username = textUsername.Text,
                    password = textPass1.Text,
                    //type = "scientist",
                    university = new MongoDBRef("University", uni.Id)
                };

            }
            else
            {
                u = new User
                {
                    username = textUsername.Text,
                    password = textPass1.Text,
                    //type = "user",
                };
            }

            topicCollecion.Insert(u);

            //University u1 = new University { Name = "Univerzitet u Nisu" };
            //University u2 = new University { Name = "Univerzitet u Beogradu" };
            //University u3 = new University { Name = "Univerzitet u Novom Sadu" };

            //universityCollection.Insert<University>(u1);
            //universityCollection.Insert<University>(u2);
            //universityCollection.Insert<University>(u3);

            parent.enableBtn();
            this.Close();
        }

        private void cbScietist_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScietist.Checked)
            {
                cbUser.Checked = false;
                comboUniversity.Enabled = true;
            }
        }

        private void cbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUser.Checked)
            {
                cbScietist.Checked = false;
                comboUniversity.Enabled = false;
            }
                
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            parent.enableBtn();
            this.Close();
        }
    }
}
