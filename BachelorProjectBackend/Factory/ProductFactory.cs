using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;
using System.Collections.Generic;

/// <summary>
/// Produces Persons 
/// </summary>
public static class ProductFactory
{
    public static Product Create(MySqlDataReader row, int startValue = 0)
    {
        //row.Read();

        Product product = new Product()
        {
            ProductId = (int)row[startValue+0],
            ProductTypeId = (int)row[startValue + 1],
            CompanyId = (int)row[startValue + 2],
            ManagerId = row[startValue + 3].ToString(),
            AdministratorId = row[startValue + 4].ToString(),
            Product_Interval = (int)row[startValue + 5],
            AdjustedId = row[startValue + 6].ToString(),
            Product_Comment = row[startValue + 7].ToString(),
            Product_Country = row[startValue + 8].ToString(),
            Currency = row[startValue + 9].ToString(),
            Product_Type = row[startValue + 10].ToString(),
            Product_DescriptionString = row[startValue + 11].ToString(),
            Product_EndDate = (DateTime)row[startValue + 12],
            Product_ExternalReference = row[startValue + 13].ToString(),
            Product_Price = Convert.ToDecimal(row[startValue + 14]),
            Product_Interests = row[startValue + 15].ToString(),
            Product_Category = row[startValue + 16].ToString(),
            Product_CommissionPrice = Convert.ToDecimal(row[startValue + 17].ToString()),
            Product_SupplierId = row[startValue + 18].ToString(),
            Product_Rating = Convert.ToDecimal(row[startValue + 19].ToString()),
            Product_Key = row[startValue + 20].ToString(),
            Product_Max = row[startValue + 21].ToString(),
            Product_Name = row[startValue + 22].ToString(),
            Product_Price2 = Convert.ToDecimal(row[startValue + 23].ToString()),
            Product_Parameters = row[startValue + 24].ToString(),
            Product_NoticeLevel = (int)row[startValue + 25],
            Product_Premium = row[startValue + 26].ToString(),
            Product_Product = row[startValue + 27].ToString(),
            Product_Version = row[startValue + 28].ToString(),
            Product_Level = Convert.ToDecimal(row[startValue + 29].ToString()),
            Product_ApprovedDate = (DateTime)row[startValue + 30],
            ResellerId = row[startValue + 31].ToString(),
            Product_Retention = (decimal)row[startValue + 32],
            Product_Rule1 = Convert.ToDecimal(row[startValue + 33].ToString()),
            Product_Rule2 = Convert.ToDecimal(row[startValue + 34].ToString()),
            Product_Rule3 = Convert.ToDecimal(row[startValue + 35].ToString()),
            Product_Method = row[startValue + 36].ToString(),
            Product_StartDate = (DateTime)row[startValue + 37],
            Product_Status = (int)row[startValue + 38],
            Product_StatusString = row[startValue + 39].ToString(),
            Product_PhoneNo = row[startValue + 40].ToString(),
            Product_URL = row[startValue + 41].ToString(),
            ProductType = row[startValue + 42].ToString()
        };
        //should be put at last index above +1.
        int currCursor = 43;
        
        while(currCursor < row.FieldCount)
        {
            switch (row.GetName(currCursor))
            {
                case "CompanyId":
                    // Add company column count to cursor
                    Company company = CompanyFactory.Create(row, currCursor);
                    currCursor += 7;
                    product.companyObject = company;
                    break;
                case "ProductTypeId":
                    // add productType column count to cursor
                    ProductType typ = ProductTypeFactory.Create(row, currCursor);
                    currCursor += 6;
                    product.productTypeObject = typ;
                    break;
                default:
                    currCursor = row.FieldCount;
                    break;
            }
        }

        return product;
    }

    public static Product Create(BsonDocument row, int startValue = 0)
    {
        // Removes the _id 
        row.RemoveAt(startValue+0);

        Product product = new Product()
        {
            ProductId = Int32.Parse(row.GetElement(startValue + 0).Value.ToString()),
            ProductTypeId = Int32.Parse(row.GetElement(startValue + 1).Value.ToString()),
            CompanyId = Int32.Parse(row.GetElement(startValue + 2).Value.ToString()),
            ManagerId = row.GetElement(startValue + 3).Value.ToString(),
            AdministratorId = row.GetElement(startValue + 4).Value.ToString(),
            Product_Interval = Int32.Parse(row.GetElement(startValue + 5).Value.ToString()),
            AdjustedId = row.GetElement(startValue + 6).Value.ToString(),
            Product_Comment = row.GetElement(startValue + 7).Value.ToString(),
            Product_Country = row.GetElement(startValue + 8).Value.ToString(),
            Currency = row.GetElement(startValue + 9).Value.ToString(),
            Product_Type = row.GetElement(startValue + 10).Value.ToString(),
            Product_DescriptionString = row.GetElement(startValue + 11).Value.ToString(),
            Product_EndDate = Convert.ToDateTime(row.GetElement(startValue + 12).Value.ToString()),
            Product_ExternalReference = row.GetElement(startValue + 13).Value.ToString(),
            Product_Price = row.GetElement(startValue + 14).Value.ToDecimal(),
            Product_Interests = row.GetElement(startValue + 15).Value.ToString(),
            Product_Category = row.GetElement(startValue + 16).Value.ToString(),
            Product_CommissionPrice = row.GetElement(startValue + 17).Value.ToDecimal(),
            Product_SupplierId = row.GetElement(startValue + 18).Value.ToString(),
            Product_Rating = row.GetElement(startValue + 19).Value.ToDecimal(),
            Product_Key = row.GetElement(startValue + 20).Value.ToString(),
            Product_Max = row.GetElement(startValue + 21).Value.ToString(),
            Product_Name = row.GetElement(startValue + 22).Value.ToString(),
            Product_Price2 = row.GetElement(startValue + 23).Value.ToDecimal(),
            Product_Parameters = row.GetElement(startValue + 24).Value.ToString(),
            Product_NoticeLevel = Int32.Parse(row.GetElement(startValue + 25).Value.ToString()),
            Product_Premium = row.GetElement(startValue + 26).Value.ToString(),
            Product_Product = row.GetElement(startValue + 27).Value.ToString(),
            Product_Version = row.GetElement(startValue + 28).Value.ToString(),
            Product_Level = row.GetElement(startValue + 29).Value.ToDecimal(),
            Product_ApprovedDate = Convert.ToDateTime(row.GetElement(startValue + 30).Value.ToString()),
            ResellerId = row.GetElement(startValue + 31).Value.ToString(),
            Product_Retention = row.GetElement(startValue + 32).Value.ToDecimal(),
            Product_Rule1 = row.GetElement(startValue + 33).Value.ToDecimal(),
            Product_Rule2 = row.GetElement(startValue + 34).Value.ToDecimal(),
            Product_Rule3 = row.GetElement(startValue + 35).Value.ToDecimal(),
            Product_Method = row.GetElement(startValue + 36).Value.ToString(),
            Product_StartDate = Convert.ToDateTime(row.GetElement(startValue + 37).Value.ToString()),
            Product_Status = Int32.Parse(row.GetElement(startValue + 38).Value.ToString()),
            Product_StatusString = row[startValue + 39].ToString(),
            Product_PhoneNo = row.GetElement(startValue + 40).Value.ToString(),
            Product_URL = row.GetElement(startValue + 41).Value.ToString(),
            ProductType = row.GetElement(startValue + 42).Value.ToString(),
        };

        //should be put at last index above +1.
        int currCursor = 43;
        BsonDocument document;
        while (currCursor < row.ElementCount)
        {
            switch (row.GetElement(currCursor).Name)
            {
                case "Company_object":
                    document = new BsonDocument(row.GetElement(currCursor).Value[0].AsBsonDocument);
                    Company company = CompanyFactory.Create(document);
                    product.companyObject = company;
                    currCursor++;
                    break;
                case "ProductType_object":
                    document = new BsonDocument(row.GetElement(currCursor).Value[0].AsBsonDocument);
                    ProductType productType = ProductTypeFactory.Create(document);
                    product.productTypeObject = productType;
                    currCursor++;
                    break;
                default:
                    currCursor = row.ElementCount;
                    break;
            }
        }

        return product;
    }
}
