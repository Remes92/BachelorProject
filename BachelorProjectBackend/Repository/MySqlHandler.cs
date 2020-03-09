using System;
using System.Collections.Generic;
using BachelorProjectBackend.Models;

using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for MySqlHandler
/// </summary>

namespace BachelorProjectBackend.Repository
{
    public class MySqlHandler
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Database { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }

        public MySqlHandler()
        {
            Server = "192.168.128.63";
            User = "dbuser";
            Database = "bachelorproject_db";
            Port = 3306;
            Password = "123";
        }

        public MySqlHandler(string server, string user, string database, int port, string password)
        {
            this.Server = server;
            this.User = user;
            this.Database = database;
            this.Port = port;
            this.Password = password;

        }

        private MySqlConnection Connect()
        {
            String connStr = "server=" + Server + ";user=" + User + ";database=" + Database + ";port=" + Port + ";password=" + Password;
            return new MySqlConnection(connStr);
        }

        public Person GetPersonById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM person WHERE PersonId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                Person person = PersonFactory.Create(rdr);
                return person;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public ProductType GetProductTypeById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM productType WHERE ProductTypeId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                ProductType productType = ProductTypeFactory.Create(rdr);
                return productType;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Company GetCompanyById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM company WHERE CompanyId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                Company company = CompanyFactory.Create(rdr);
                return company;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Department GetDepartmentById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM department WHERE DepartmentId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                /*
                 Create company(rdr[0 - 45])
                 Create Product(rdr,45);
                  row[bound+1)
                 */

                Department department = DepartmentFactory.Create(rdr);
                return department;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Product> GetProductById(int lower, int upper)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * "+ 
                             "FROM bachelorproject_db.product " +
                             "WHERE product.ProductId BETWEEN " + lower + " AND " + upper;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Product> products = new List<Product>();
                while (rdr.Read())
                {
                    products.Add(ProductFactory.Create(rdr));

                }
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Product> GetProductJoinProductTypeById(int lower, int upper)
        {

            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * " +
                             "FROM product " +
                             "JOIN producttype ON producttype.productTypeId = product.productTypeId " +
                             "WHERE product.ProductId BETWEEN "+lower+" AND " + upper;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Product> products = new List<Product>();
                while (rdr.Read())
                {
                    products.Add(ProductFactory.Create(rdr));

                }
                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Product> GetProductJoinProductTypeAndCompanyById(int lower, int upper)
        {

            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * " +
                             "FROM product " +
                             "JOIN producttype ON producttype.productTypeId = product.productTypeId " +
                             "JOIN company ON company.CompanyId = product.CompanyId " +
                             "WHERE product.ProductId BETWEEN " + lower + " AND " + upper;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Product> products = new List<Product>();
                while (rdr.Read())
                {
                    products.Add(ProductFactory.Create(rdr));

                }

                return products;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public Product GetProductById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM product WHERE ProductId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                Product product = ProductFactory.Create(rdr);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Product GetProductJoinProductTypeById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * "+ 
                             "FROM product " +
                             "JOIN producttype ON producttype.productTypeId = product.productTypeId " +
                             "WHERE ProductId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();

                Product product = ProductFactory.Create(rdr);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Product GetProductJoinProductTypeAndCompanyById(int id)
        {
            MySqlConnection conn = Connect();
            try
            {
                conn.Open();
                string sql = "SELECT * " +
                             "FROM product " +
                             "JOIN producttype ON producttype.productTypeId = product.productTypeId " +
                             "JOIN company ON company.CompanyId = product.CompanyId " +
                             "WHERE ProductId = " + id;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                Product product = ProductFactory.Create(rdr);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
