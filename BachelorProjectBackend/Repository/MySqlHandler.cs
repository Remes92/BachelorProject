using System;
using BachelorProjectBackend.Models;

using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for MySqlHandler
/// </summary>
public class MySqlHandler
{
    public string Server { get; set; }
    public string User { get; set; }
    public string Database { get; set; }
    public int Port { get; set; }
    public string Password { get; set; }

    public MySqlHandler()
	{
        Server = "127.0.0.1";
        User = "root";
        Database = "bachelorproject_db";
        Port = 3306;
        Password = "";
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

            Person p = PersonFactory.Create(rdr);
            return p;
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
