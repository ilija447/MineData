using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MineData
{
    class Animal
    {
        public ObjectId Id { get; set; }
        public string name {get; set;}
        public DateTime date { get; set; }
        public List<Property> properties { get; set; }
        public MongoDBRef topic { get; set; }
        //public MongoDBRef university { get; set; }

        

    }
}
