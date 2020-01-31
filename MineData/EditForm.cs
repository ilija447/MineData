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
    public partial class EditForm : MaterialSkin.Controls.MaterialForm
    {
        private String topic;
        private Topic t;
        private User user;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string t)
        {
            InitializeComponent();
            topic = t;

            showData();
        }

        private void showData()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollection = database.GetCollection<Topic>("Topics");

            var query1 = from Topics in topicCollection.AsQueryable<Topic>()
                         where Topics.name == topic
                         select Topics;

            t = query1.First();

            list.Items.Clear();

            foreach (MongoDBRef tmpRef in t.data)
            {
                Animal tmp = database.FetchDBRefAs<Animal>(tmpRef);
                list.Items.Add((list.Items.Count + 1) + ". " + tmp.name + ", date: " + tmp.date);
            }

        }

        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            Animal animal=database.FetchDBRefAs<Animal>(t.data[list.SelectedIndex]);

            lblName.Text = animal.name;
            lblDate.Text = animal.date.ToShortDateString();

            addComboData(animal);


        }

        private void addComboData(Animal animal) 
        {
            comboProp.Items.Clear();
            textPropValue.Clear();
            textPropName.Clear();
            foreach (Property tmp in animal.properties)
            {
                comboProp.Items.Add(tmp.Name + "= " + tmp.Value);

            }
        }

        private void clearAll() 
        {
            textPropValue.Clear();
            textPropName.Clear();
            lblDate.Text = "";
            lblName.Text = "";
            comboProp.Items.Clear();
            comboProp.Text = "";
            textName.Clear();
        }
        private void comboProp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            Animal animal = database.FetchDBRefAs<Animal>(t.data[list.SelectedIndex]);

            lblName.Text = animal.name;
            lblDate.Text = animal.date.ToShortDateString();

            textPropName.Text = animal.properties[comboProp.SelectedIndex].Name;
            textPropValue.Text = animal.properties[comboProp.SelectedIndex].Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");
            var collection = database.GetCollection<Animal>("Animals");

            Animal animal = database.FetchDBRefAs<Animal>(t.data[list.SelectedIndex]);

            if (textName.TextLength > 0)
                animal.name = textName.Text;
            animal.date = dateTime.Value;

            if(textPropName.TextLength>0 && textPropValue.TextLength>0)
            {
                animal.properties[comboProp.SelectedIndex].Name = textPropName.Text;
                animal.properties[comboProp.SelectedIndex].Value = textPropValue.Text;
            }

            collection.Save(animal);

            clearAll();
            showData();
        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            if (textPropName.TextLength < 1 || textPropValue.TextLength <1)
            {
                MessageBox.Show("Enter property");
                return;
            }
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");
            var collection = database.GetCollection<Animal>("Animals");

            Animal animal = database.FetchDBRefAs<Animal>(t.data[list.SelectedIndex]);

            animal.properties.Add(new Property { Name = textPropName.Text, Value = textPropValue.Text });
            collection.Save(animal);
            addComboData(animal);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollection = database.GetCollection<Topic>("Topics");

            MongoDBRef animalRef = t.data[list.SelectedIndex];
            Animal animal = database.FetchDBRefAs<Animal>(animalRef);


            t.data.RemoveAt(list.SelectedIndex);
            topicCollection.Save(t);
            collection.Remove(Query.EQ("_id", animal.Id));
            showData();
        }
    }
}
