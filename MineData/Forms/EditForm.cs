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
        //private String topic;
        //private Topic t;
        private string university;
        private University u;


        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(string u)
        {
            InitializeComponent();
            //topic = t;
            university = u;
            showData();
        }

        private void showData()
        {
            MongoDatabase database = MongoService.getDatabase();

            var collection = database.GetCollection<Animal>("Animals");
            var universityCollection = database.GetCollection<University>("University");

            var query1 = from University in universityCollection.AsQueryable<University>()
                         where University.Name == university
                         select University;

            u = query1.First();



            list.Items.Clear();

            foreach (MongoDBRef tmpRef in u.generatedData)
            {
                Animal tmp = database.FetchDBRefAs<Animal>(tmpRef);
                Topic t = database.FetchDBRefAs<Topic>(tmp.topic);
                list.Items.Add((list.Items.Count + 1) + ". " + tmp.name + ", date: " + tmp.date+
                    "  -  topic:"+t.name);
            }

        }

        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            if (list.SelectedItem == null)
                return;

            MongoDatabase database = MongoService.getDatabase();

            Animal animal=database.FetchDBRefAs<Animal>(u.generatedData[list.SelectedIndex]);

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
            MongoDatabase database = MongoService.getDatabase();

            Animal animal = database.FetchDBRefAs<Animal>(u.generatedData[list.SelectedIndex]);

            lblName.Text = animal.name;
            lblDate.Text = animal.date.ToShortDateString();

            textPropName.Text = animal.properties[comboProp.SelectedIndex].Name;
            textPropValue.Text = animal.properties[comboProp.SelectedIndex].Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MongoDatabase database = MongoService.getDatabase();
            var collection = database.GetCollection<Animal>("Animals");

            Animal animal = database.FetchDBRefAs<Animal>(u.generatedData[list.SelectedIndex]);

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
            MongoDatabase database = MongoService.getDatabase();
            var collection = database.GetCollection<Animal>("Animals");

            Animal animal = database.FetchDBRefAs<Animal>(u.generatedData[list.SelectedIndex]);

            animal.properties.Add(new Property { Name = textPropName.Text, Value = textPropValue.Text });
            collection.Save(animal);
            addComboData(animal);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MongoDatabase database = MongoService.getDatabase();

            var collection = database.GetCollection<Animal>("Animals");
            var UniversityCollection = database.GetCollection<University>("University");

            MongoDBRef animalRef = u.generatedData[list.SelectedIndex];
            Animal animal = database.FetchDBRefAs<Animal>(animalRef);


            u.generatedData.RemoveAt(list.SelectedIndex);
            UniversityCollection.Save(u);
            collection.Remove(Query.EQ("_id", animal.Id));
            showData();
        }
    }
}
