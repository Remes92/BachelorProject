using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using BachelorProjectBackend.Models;
using Newtonsoft.Json;

namespace BachelorProjectBackend.Repository
{
    public class MongoHandler
    {
        public string server { get; set; }
        public string user { get; set; }
        public string database { get; set; }
        public int port { get; set; }
        public string password { get; set; }

        private static MongoClient dbClient = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=BachelorProjectBackend&ssl=false");

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
            MongoClient dbClient = new MongoClient("mongodb://"+user+":"+password+"@"+server+":"+port);          
            return dbClient;
        }

        public Person GetPersonById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Person");
                var filter = Builders<BsonDocument>.Filter.Eq("PersonId", id.ToString());
                var personDocument = collection.Find(filter).FirstOrDefault();
                Person p = PersonFactory.Create(personDocument);
                return p;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }
}
