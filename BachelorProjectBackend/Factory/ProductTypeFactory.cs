using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class ProductTypeFactory
{
    public static ProductType Create(MySqlDataReader row)
    {
        row.Read();

        ProductType productType = new ProductType()
        {
            ProductTypeId = (int)row[0],
            ProductType_DescriptionString = row[1].ToString(),
            ProductType_KeySellingPoint = row[2].ToString(),
            ProductType_Label = row[3].ToString(),
            ProductType_Name = row[4].ToString(),
            ProductType_Status = (int)row[5]
        };
        return productType;
    }

    public static ProductType Create(BsonDocument row)
    {
        // Removes the _id 
        row.RemoveAt(0);

        ProductType productType = new ProductType()
        {
            ProductTypeId = Int32.Parse(row.GetElement(0).Value.ToString()),
            ProductType_DescriptionString = row.GetElement(1).Value.ToString(),
            ProductType_KeySellingPoint = row.GetElement(2).Value.ToString(),
            ProductType_Label = row.GetElement(3).Value.ToString(),
            ProductType_Name = row.GetElement(4).Value.ToString(),
            ProductType_Status = Int32.Parse(row.GetElement(5).Value.ToString())
        };
        return productType;
    }
}
