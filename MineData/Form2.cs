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
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        Form1 parent;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            parent = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textTopicName.Text.Length<1)
            {
                MessageBox.Show("Enter topic name");
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var topicCollecion = database.GetCollection<Topic>("Topics");

            Topic t = new Topic { name = textTopicName.Text };
            topicCollecion.Insert<Topic>(t);

            parent.getTopics();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
