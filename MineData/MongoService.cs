using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

namespace MineData
{
    public class MongoService
    {

        public static MongoDatabase getDatabase() {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            MongoDatabase database = server.GetDatabase("Data");

            return database;
        }

    }
}
