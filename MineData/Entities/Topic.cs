using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MineData
{
    public class Topic
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        //public List<MongoDBRef> data { get; set; }

        //public Topic() {
        //    data = new List<MongoDBRef>();
        //}
    }
}
