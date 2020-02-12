using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MineData
{
    public class University
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<MongoDBRef> generatedData { get; set; }

        public University()
        {
            generatedData = new List<MongoDBRef>();
        }

    }
}
