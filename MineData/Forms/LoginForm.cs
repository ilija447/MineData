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
using MongoDB.Driver.Builders;

namespace MineData
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void clearText()
        {
            textPassword.Clear();
            TextUsername.Clear();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getTopics()
        {
            MongoDatabase database = MongoService.getDatabase();
            var topicCollecion = database.GetCollection<Topic>("Topics");


            comboTopic.Items.Clear();
            foreach (Topic t in topicCollecion.FindAll())
            {
                comboTopic.Items.Add(t.name);
            }
        }
        private void logIn_Click(object sender, EventArgs e)
        {

            if (textPassword.TextLength < 1 || TextUsername.TextLength < 1)
            {
                MessageBox.Show("Invalid username/password combination");
                return;
            }

            MongoDatabase database = MongoService.getDatabase();

            var userCollecion = database.GetCollection<Scientist>("User");

            var query = from User in userCollecion.AsQueryable()
                        where User.username == TextUsername.Text
                        select User;

            //var u=userCollecion.FindOne<>(Query.EQ("username", TextUsername.Text));
            //MessageBox.Show(query.GetType().ToString());

            if (query.Count() == 0)
            {
                MessageBox.Show("Invalid username/password combination");
                return;
            }

            //var u=query.First();
            //if(query.GetType()==typeof(Scientist))
            //    var u = query.Cast<>();


            if (query.First().GetType() == typeof(Scientist) && query.First().university!=null)
            {
                var u = query.First();

                if (u.password == textPassword.Text)
                {
                    Form1 f = new Form1(this, (Scientist)u);
                    f.Show();
                    clearText();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/password combination");
                    return;
                }
            }
            else
            {
                var u = query.First();
                if (u.password == textPassword.Text)
                {
                    devTopic.BackColor = Color.FromArgb(150, 255, 255, 255);
                    lblTopic.Visible = true;
                    btnTopic.Visible = true;
                    comboTopic.Visible = true;
                    getTopics();

                    logIn.Enabled = false;
                    Register.Enabled = false;
                    textPassword.Enabled = false;
                    TextUsername.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Invalid username/password combination");
                    return;
                }
            }
                


            //if (u.password==textPassword.Text)
            //{

            //    if (query.GetType() == typeof(User))
            //    {
                    
            //        devTopic.BackColor=Color.FromArgb(150, 255, 255, 255);
            //        lblTopic.Visible = true;
            //        btnTopic.Visible = true;
            //        comboTopic.Visible=true;
            //        getTopics();

            //        logIn.Enabled = false;
            //        Register.Enabled = false;
            //        textPassword.Enabled = false;
            //        TextUsername.Enabled = false;
            //    }
            //    else
            //    {
            //        Form1 f = new Form1(this,(Scientist)u);
            //        f.Show();
            //        clearText();
            //        this.Hide();

            //    }
            //    //Form1 f = new Form1(this);
            //    //f.Show();
            //    //clearText();
            //    //this.Hide();

            //}
            //else
            //{
            //    MessageBox.Show("Invalid username/password combination");
            //    return;
            //}

            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form f = new registerForm(this);
            f.Show();
            logIn.Enabled = false;
            Register.Enabled = false;
        }

        public void enableBtn() {
            logIn.Enabled = true;
            Register.Enabled = true;
        }

        private void comboTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            if (comboTopic.SelectedItem == null)
            {
                MessageBox.Show("Pick a topic");
                return;
            }

            Form3 f = new Form3(this.comboTopic.SelectedItem.ToString());
            f.Show();
        }
    }
}
