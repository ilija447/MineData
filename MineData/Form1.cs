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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private List<Property> tmpProps;

        private Form logForm;
        private Scientist logedUser;
        private University university;
        public Form1()
        {
            InitializeComponent();

            tmpProps = new List<Property>();

            

            getTopics();
        }

        public Form1(Form f, Scientist u)
        {
            InitializeComponent();

            tmpProps = new List<Property>();

            logForm = f;
            logedUser = u;

            
            getUniversity();
            getTopics();

            this.Text += " - " + university.Name;
        }

        private void getUniversity() {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            university= database.FetchDBRefAs<University>(logedUser.university);
        }

        public void getTopics() {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");
            var topicCollecion = database.GetCollection<Topic>("Topics");


            comboTopic.Items.Clear();
            foreach (Topic t in topicCollecion.FindAll())
            {
                comboTopic.Items.Add(t.name);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboTopic.SelectedItem == null)
            {
                MessageBox.Show("Pick a topic");
                return;
            }

            if (textName.TextLength < 1)
            {
                MessageBox.Show("Enter name");
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollecion = database.GetCollection<Topic>("Topics");
            var universityCollection = database.GetCollection<University>("University");

            var query1 = from Topics in topicCollecion.AsQueryable<Topic>()
                         where Topics.name == comboTopic.SelectedItem.ToString()
                         select Topics;

            Topic t = query1.First();


            Animal a = new Animal
            {
                name = this.textName.Text,
                date = this.dateTime.Value,
                properties = tmpProps,
                topic = new MongoDBRef("Topics", t.Id),
                //university = new MongoDBRef("University", university.Id)
            };

            collection.Insert<Animal>(a);

            university.generatedData.Add(new MongoDBRef("Animals", a.Id));

            //topicCollecion.Save(t);
            universityCollection.Save(university);

            tmpProps.Clear();
            listProp.Items.Clear();
            textName.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (textPropName.Text.Length<1 || textPropValue.Text.Length < 1)
            {
                MessageBox.Show("Enter property");
                return;
            }
           

            //float pom;
            //if(float.TryParse(textPropValue.Text,out pom))
            //{
            //    tmpProps.Add(new NumProperty { Name = textPropName.Text, Value = pom });
            //}
            //else
            //{
            //    tmpProps.Add(new StringProperty { Name = textPropName.Text, Value = textPropValue.Text });
            //}

            tmpProps.Add(new Property { Name = textPropName.Text, Value = textPropValue.Text });

            
            listProp.Items.Add((listProp.Items.Count+1)+". "+textPropName.Text +" = "+ textPropValue.Text);
            textPropValue.Clear();
            textPropName.Clear();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (comboTopic.SelectedItem == null)
            {
                MessageBox.Show("Pick a topic");
                return;
            }

            Form3 f = new Form3(this.comboTopic.SelectedItem.ToString());
            f.Show();

        }

        private void btnNewTopic_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2(this);
            forma.Show();

            this.getTopics();
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            if (comboTopic.SelectedItem == null)
            {
                MessageBox.Show("Pick a topic");
                return;
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollection = database.GetCollection<Topic>("Topics");


            var query1 = from Topics in topicCollection.AsQueryable<Topic>()
                         where Topics.name == comboTopic.SelectedItem.ToString()
                         select Topics;

            Topic t = query1.First();

            //foreach (MongoDBRef animalRef in university.generatedData)
            //{
            //    Animal tmp = database.FetchDBRefAs<Animal>(animalRef);
            //    //MessageBox.Show(tmp.name);
            //    collection.Remove(Query.EQ("_id", tmp.Id));
            //}

            topicCollection.Remove(Query.EQ("_id", t.Id));
        }

        private void listProp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(logForm!=null)
                logForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (comboTopic.SelectedItem == null)
            {
                MessageBox.Show("Pick a topic");
                return;
            }
            EditForm f = new EditForm(university.Name);
            f.Show();
        }
    }
}
