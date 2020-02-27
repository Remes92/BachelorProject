using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class DepartmentFactory
{
    public static Department Create(MySqlDataReader row)
    {
        row.Read();

        Department department = new Department()
        {
            DepartmentId = (int)row[0],
            CompanyId = (int)row[1],
            Department_Description = row[2].ToString(),
            Department_Key = row[3].ToString(),
            Department_Label = row[4].ToString(),
            Department_Name = row[5].ToString(),
        };
        return department;
    }

    public static Department Create(BsonDocument row)
    {
        // Removes the _id 
        row.RemoveAt(0);

        Department department = new Department()
        {
            DepartmentId = Int32.Parse(row.GetElement(0).Value.ToString()),
            CompanyId = Int32.Parse(row.GetElement(1).Value.ToString()),
            Department_Description = row.GetElement(2).Value.ToString(),
            Department_Key = row.GetElement(3).Value.ToString(),
            Department_Label = row.GetElement(4).Value.ToString(),
            Department_Name = row.GetElement(5).Value.ToString()
        };
        return department;
    }
}
