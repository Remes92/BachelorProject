using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class CompanyFactory
{
    public static Company Create(MySqlDataReader row, int startValue = 0)
    {

        Company company = new Company()
        {
            CompanyId = (int)row[startValue + 0],
            Company_Name = row[startValue + 1].ToString(),
            Company_DirectionIn = (Boolean)row[startValue + 2],
            Company_DirectionOut = (Boolean)row[startValue + 3],
            Company_Phone = row[startValue + 4].ToString(),
            Company_Label = row[startValue + 5].ToString(),
            Company_Slogan = row[startValue + 6].ToString()
        };
        return company;
    }

    public static Company Create(BsonDocument row, int startValue)
    {
        // Removes the _id 
        row.RemoveAt(0);

        Company company = new Company()
        {
            CompanyId = Int32.Parse(row.GetElement(startValue + 0).Value.ToString()),
            Company_Name = row.GetElement(startValue + 1).Value.ToString(),
            Company_DirectionIn = Convert.ToBoolean(Int32.Parse(row.GetElement(startValue + 2).Value.ToString())),
            Company_DirectionOut = Convert.ToBoolean(Int32.Parse(row.GetElement(startValue + 3).Value.ToString())),
            Company_Phone = row.GetElement(startValue + 4).Value.ToString(),
            Company_Label = row.GetElement(startValue + 5).Value.ToString(),
            Company_Slogan = row.GetElement(startValue + 6).Value.ToString()
        };
        return company;
    }
}
