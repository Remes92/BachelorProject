using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class ProductTypeFactory
{
    public static ProductType Create(MySqlDataReader row, int startValue = 0)
    {

        ProductType productType = new ProductType()
        {
            ProductTypeId = (int)row[startValue+0],
            ProductType_DescriptionString = row[startValue + 1].ToString(),
            ProductType_KeySellingPoint = row[startValue + 2].ToString(),
            ProductType_Label = row[startValue + 3].ToString(),
            ProductType_Name = row[startValue + 4].ToString(),
            ProductType_Status = (int)row[startValue + 5]
        };
        return productType;
    }

    public static ProductType Create(BsonDocument row, int startValue = 0)
    {
        // Removes the _id 
        row.RemoveAt(0);

        ProductType productType = new ProductType()
        {
            ProductTypeId = row.GetElement(startValue + 0).Value.ToInt32(),
            ProductType_DescriptionString = row.GetElement(startValue + 1).Value.ToString(),
            ProductType_KeySellingPoint = row.GetElement(startValue + 2).Value.ToString(),
            ProductType_Label = row.GetElement(startValue + 3).Value.ToString(),
            ProductType_Name = row.GetElement(startValue + 4).Value.ToString(),
            ProductType_Status = row.GetElement(startValue + 5).Value.ToInt32(),
        };
        return productType;
    }
}
