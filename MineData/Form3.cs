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
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        private String topic;
        private Topic t;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(String t)
        {
            InitializeComponent();
            topic = t;

            showData();
        }

        private void showData() {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollection = database.GetCollection<Topic>("Topics");

            var query1 = from Topics in topicCollection.AsQueryable<Topic>()
                         where Topics.name == topic
                         select Topics;

            t = query1.First();

            //var query = from Animals in collection.AsQueryable<Animal>()
            //             where Animals.properties
            //             select Animals;

            //foreach(Animal a in query)
            //{
            //    MessageBox.Show(a.name);
            //}



            //list.Items.Clear();

            List<Animal> lista = new List<Animal>();

            List<IMongoQuery> queries = new List<IMongoQuery>();
            queries.Add(Query.EQ("topic.$id", t.Id));

            foreach (Animal tmp in collection.Find(Query.And(queries)))
            {

                Topic t = database.FetchDBRefAs<Topic>(tmp.topic);
                lista.Add(tmp);
            }

            list.DataSource = lista;
            list.DisplayMember = "name";
            list.ValueMember = "Id";
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list.SelectedItem == null)
                return;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            Animal animal = collection.FindOne(Query.EQ("_id", ObjectId.Parse(list.SelectedValue.ToString())));

            String props ="";
            int brojac = 1;

            foreach(Property tmp in animal.properties)
            {
                props += brojac+". "+tmp.Name + ":  " + tmp.Value+"  \n";
            }

            //MessageBox.Show(list.SelectedItem.ToString());
            MessageBox.Show(props, animal.name + " properties",MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            var collection = database.GetCollection<Animal>("Animals");
            var topicCollection = database.GetCollection<Topic>("Topics");

            int dataCount = 9999999;

            List<IMongoQuery> queries = new List<IMongoQuery>();
            queries.Add(Query.EQ("topic.$id", t.Id));

            if (textCount.TextLength > 0)
                dataCount = Int32.Parse(textCount.Text);

            if (textNoPops.TextLength > 0)
                queries.Add(Query.Size("properties", Int32.Parse(textNoPops.Text)));

            if (textName.TextLength > 0)
                queries.Add(Query.EQ("name", textName.Text));

            if (rbProp.Checked&& textPropName.TextLength > 0 && textPropValue.TextLength > 0)
            {

                //db.collection.find( { {properties : {Name: }} : { $exists: true } } );
                var jsonQuery = "{ properties : {\"Name\" : \"" + textPropName.Text + "\", \"Value\" : \"" +
                    textPropValue.Text + "\" }}";

                
                BsonDocument doc = MongoDB.Bson.Serialization
                                   .BsonSerializer.Deserialize<BsonDocument>(jsonQuery);

                queries.Add(new QueryDocument(doc));

                //queries.Add(Query.Find()};
            }

            foreach (Animal a in collection.Find(Query.And(queries)).SetLimit(dataCount))
            {
                MessageBox.Show(a.name);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void list_Format(object sender, ListControlConvertEventArgs e)
        {
            String name = ((Animal)e.ListItem).name;
            String date = ((Animal)e.ListItem).date.ToString();

            e.Value = "   Name: " + name + ", Date: " + date;
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(!rbValue.Checked)
            {
                lblCount.Visible = false;
                textCount.Visible = false;
                lblNoOfProps.Visible = false;
                textNoPops.Visible = false;
                lblName.Visible = false;
                textName.Visible = false;

                lblPropName.Visible = true;
                textPropName.Visible = true;
                lblPropValue.Visible = true;
                textPropValue.Visible = true;

                clearText();
            }
        }

        private void rbProp_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbProp.Checked)
            {
                lblCount.Visible = true;
                textCount.Visible = true;
                lblNoOfProps.Visible = true;
                textNoPops.Visible = true;
                lblName.Visible = true;
                textName.Visible = true;

                lblPropName.Visible = false;
                textPropName.Visible = false;
                lblPropValue.Visible = false;
                textPropValue.Visible = false;

                clearText();
            }
        }

        private void clearText()
        {
            textNoPops.Text = "";
            textCount.Text = "";
            textName.Text = "";
            textPropName.Text = "";
            textPropValue.Text = "";
        }
    }
}


//var database = server.GetDatabase("Data");

//var collection = database.GetCollection<Animal>("Animals");
//Animal animal = collection.FindOne(Query.EQ("_id", ObjectId.Parse(list.SelectedValue.ToString())));