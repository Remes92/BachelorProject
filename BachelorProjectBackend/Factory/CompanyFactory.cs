using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class CompanyFactory
{
    public static Company Create(MySqlDataReader row)
    {
        row.Read();

        Company company = new Company()
        {
            CompanyId = (int)row[0],
            Company_Name = row[1].ToString(),
            Company_DirectionIn = (Boolean)row[2],
            Company_DirectionOut = (Boolean)row[3],
            Company_Phone = row[4].ToString(),
            Company_Label = row[5].ToString(),
            Company_Slogan = row[6].ToString()
        };
        return company;
    }

    public static Company Create(BsonDocument row)
    {
        // Removes the _id 
        row.RemoveAt(0);

        Company company = new Company()
        {
            CompanyId = Int32.Parse(row.GetElement(0).Value.ToString()),
            Company_Name = row.GetElement(1).Value.ToString(),
            Company_DirectionIn = Convert.ToBoolean(Int32.Parse(row.GetElement(2).Value.ToString())),
            Company_DirectionOut = Convert.ToBoolean(Int32.Parse(row.GetElement(3).Value.ToString())),
            Company_Phone = row.GetElement(4).Value.ToString(),
            Company_Label = row.GetElement(5).Value.ToString(),
            Company_Slogan = row.GetElement(6).Value.ToString()
        };
        return company;
    }
}
