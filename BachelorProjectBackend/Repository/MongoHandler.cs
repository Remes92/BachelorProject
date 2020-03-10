using System;
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
            MongoClient dbClient = new MongoClient("mongodb://" + user + ":" + password + "@" + server + ":" + port);
            return dbClient;
        }

        public Person GetPersonById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Person");
                var filter = Builders<BsonDocument>.Filter.Eq("PersonId", id);
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

        public ProductType GetProductTypeById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("ProductType");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductTypeId", id);
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
                var filter = Builders<BsonDocument>.Filter.Eq("CompanyId", id);
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

        public Product GetProductById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductId", id);
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

        public List<Product> GetProductById(int lower, int upper)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("ProductId", lower) & builder.Lte("ProductId", upper);
                var documents = collection.Find(filter).ToList();

                List<Product> products = new List<Product>();

                for (int i = 0; i < documents.Count; i++)
                {
                    products.Add(ProductFactory.Create(documents[i]));
                }
                return products;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<Product> GetProductJoinProductTypeById(int lower, int upper)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("ProductId", lower) & builder.Lte("ProductId", upper);

                var aggregation = collection.Aggregate()
                    .Lookup("ProductType", "productTypeId", "ProductTypeId", "ProductType_object")
                    .Match(filter)
                    ;

                var documents = aggregation.ToList();

                List<Product> products = new List<Product>();

                for (int i = 0; i < documents.Count; i++)
                {
                    products.Add(ProductFactory.Create(documents[i]));
                }
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public List<Product> GetProductJoinProductTypeAndCompanyById(int lower, int upper)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Gte("ProductId", lower) & builder.Lte("ProductId", upper);

                var aggregation = collection.Aggregate()
                    .Lookup("ProductType", "productTypeId", "ProductTypeId", "ProductType_object")
                    .Lookup("Company", "CompanyId", "CompanyId", "Company_object")
                    .Match(filter)
                    ;

                var documents = aggregation.ToList();

                List<Product> products = new List<Product>();

                for (int i = 0; i < documents.Count; i++)
                {
                    products.Add(ProductFactory.Create(documents[i]));
                }
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public Product GetProductJoinProductTypeById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductId", id);

                var aggregation = collection.Aggregate()
                    .Lookup("ProductType", "productTypeId", "ProductTypeId", "ProductType_object")
                    .Match(filter)
                    ;

                var documents = aggregation.ToList();
                var document = documents[0];
                Product product = ProductFactory.Create(document);

                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public Product GetProductJoinProductTypeAndCompanyById(int id)
        {
            try
            {
                var db = dbClient.GetDatabase(database);
                var collection = db.GetCollection<BsonDocument>("Product");
                var filter = Builders<BsonDocument>.Filter.Eq("ProductId", id);

                var aggregation = collection.Aggregate()
                    .Lookup("ProductType", "productTypeId", "ProductTypeId", "ProductType_object")
                    .Lookup("Company", "CompanyId", "CompanyId", "Company_object")
                    .Match(filter)
                    ;

                var documents = aggregation.ToList();
                var document = documents[0];
                Product product = ProductFactory.Create(document);

                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }

}
