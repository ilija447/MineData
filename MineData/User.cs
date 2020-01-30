using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MineData
{
    class User
    {
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }
    }
}
