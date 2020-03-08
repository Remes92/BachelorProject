﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
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
                var document = collection.Find(filter).FirstOrDefault();
                Person person = PersonFactory.Create(document);
                return person;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public Product GetProductById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductId", id.ToString());
                var document = collection.Find(filter).FirstOrDefault();
                Product product = ProductFactory.Create(document);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public ProductType GetProductTypeById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("ProductType");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductTypeId", id.ToString());
                var document = collection.Find(filter).FirstOrDefault();
                ProductType productType = ProductTypeFactory.Create(document);
                return productType;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public Company GetCompanyById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Company");
                var filter = Builders<BsonDocument>.Filter.Eq("CompanyId", id.ToString());
                var document = collection.Find(filter).FirstOrDefault();
                Company company = CompanyFactory.Create(document);
                return company;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public Department GetDepartmentById(int lower, int upper)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("test");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("CompanyId",2) & builder.Lte("CompanyId",8);
                var d = collection.Find(filter).ToList();

                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public string GetProductJoinTypeById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductId", id.ToString());


                var aggregation = collection.Aggregate()
                    .Lookup("ProductType", "productTypeId", "ProductTypeId", "ProductType_object")
                    ;
                var result = aggregation.ToList();


                var document = collection.Find(filter).FirstOrDefault();
                Product product = ProductFactory.Create(document);
                return product.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
