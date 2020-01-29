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
    public partial class Form3 : Form
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



            list.Items.Clear();
            foreach(MongoDBRef tmpRef in t.data)
            {
                Animal tmp = database.FetchDBRefAs<Animal>(tmpRef);
                list.Items.Add((list.Items.Count + 1) + ". " + tmp.name + ", date: " + tmp.date);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Data");

            MongoDBRef animalRef = t.data[list.SelectedIndex];
            Animal animal= database.FetchDBRefAs<Animal>(animalRef);

            String props="";
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

            if(textNoPops.TextLength>0)
                queries.Add(Query.Size("properties", 1));


            //var jsonQuery = "{ properties : [ {\"Name\" : \"aa\", \"Value\" : \"12\" }]}";
            //BsonDocument doc = MongoDB.Bson.Serialization
            //                   .BsonSerializer.Deserialize<BsonDocument>(jsonQuery);

            //queries.Add(new QueryComplete(doc));

            if (textPropName.TextLength > 0 && textPropValue.TextLength > 0)
            {
                var jsonQuery = "{ properties : [ {\"Name\" : \"" + textPropName.Text + "\", \"Value\" : \"" +
                    textPropValue.Text + "\" }]}";
                //var jsonQuery = "{ properties : [ {\"Name\" : \"aa\", \"Value\" : \"12\" }]}";
                BsonDocument doc = MongoDB.Bson.Serialization
                                   .BsonSerializer.Deserialize<BsonDocument>(jsonQuery);

                queries.Add(new QueryComplete(doc));

            }

            //var q1= Query.And(queries);
            //var finalQuery = Query<Animal>.ElemMatch(p => p., builder => q1);

            foreach (Animal a in collection.Find(Query.And(queries)).SetLimit(dataCount))
            {
                MessageBox.Show(a.name);
            }
        }
    }
}
