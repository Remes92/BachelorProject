using System;
using BachelorProjectBackend.Models;

using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for MySqlHandler
/// </summary>
public class MySqlHandler
{
    public string server { get; set; }
    public string user { get; set; }
    public string database { get; set; }
    public int port { get; set; }
    public string password { get; set; }

    public MySqlHandler()
	{
        server = "127.0.0.1";
        user = "root";
        database = "bachelorproject_db";
        port = 3306;
        password = "";
	}

    public MySqlHandler(string server, string user, string database, int port, string password)
    {
        this.server = server;
        this.user = user;
        this.database = database;
        this.port = port;
        this.password = password;

    }

    private MySqlConnection Connect()
    {
        String connStr = "server=" + server + ";user=" + user + ";database=" + database + ";port=" + port + ";password=" + password;
        return new MySqlConnection(connStr);
    }

    public Person getPersonById(int id)
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
