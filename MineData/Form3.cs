﻿using System;
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
    }
}
