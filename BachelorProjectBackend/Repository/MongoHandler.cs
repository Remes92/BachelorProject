using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using BachelorProjectBackend.Models;

namespace BachelorProjectBackend.Repository
{
    class MongoHandler
    {
        public string server { get; set; }
        public string user { get; set; }
        public string database { get; set; }
        public int port { get; set; }
        public string password { get; set; }

        public MongoHandler()
        {
            server = "127.0.0.1";
            user = "root";
            database = "bachelorproject_db";
            port = 27017;
            password = "";
        }

        public MongoHandler(string server, string user, string database, int port, string password)
        {
            this.server = server;
            this.user = user;
            this.database = database;
            this.port = port;
            this.password = password;

        }

        private MongoClient Connect()
        {
            MongoClient dbClient = new MongoClient("mongodb://"+user+":"+password+"@"+server+":"+port+"/"+database);

            return dbClient;
        }

        public Person GetPersonById(int id)
        {
            MongoClient dbClient = Connect();
            try
            {
                var db = dbClient.GetDatabase(database);
                //TODO start here, get data from persn by PersonId.
                var collection = db.GetCollection<BsonDocument>("Person");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            Person p = PersonFactory.Create();
            return p;
        }

    }
}
