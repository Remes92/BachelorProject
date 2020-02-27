using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;
using MongoDB.Bson;

/// <summary>
/// Produces Persons 
/// </summary>
public static class ProductFactory
{
    public static Product Create(MySqlDataReader row)
    {
        row.Read();

        Product product = new Product()
        {
            ProductId = (int)row[0],
            ProductTypeId = (int)row[1],
            CompanyId = (int)row[2],
            ManagerId = row[3].ToString(),
            AdministratorId = row[4].ToString(),
            Product_Interval = (int)row[5],
            AdjustedId = row[6].ToString(),
            Product_Comment = row[7].ToString(),
            Product_Country = row[8].ToString(),
            Currency = row[9].ToString(),
            Product_Type = row[10].ToString(),
            Product_DescriptionString = row[11].ToString(),
            Product_EndDate = (DateTime)row[12],
            Product_ExternalReference = row[13].ToString(),
            Product_Price = (decimal)row[14],
            Product_Parameters = row[15].ToString(),
            Product_Interests = row[16].ToString(),
            Product_Category = row[17].ToString(),
            Product_CommissionPrice = (decimal)row[18],
            Product_SupplierId = row[19].ToString(),
            Product_Rating = (decimal)row[20],
            Product_Key = row[21].ToString(),
            Product_Max = row[22].ToString(),
            Product_Name = row[23].ToString(),
            Product_Price2 = (decimal)row[24],            
            Product_NoticeLevel = (int)row[25],
            Product_Premium = row[26].ToString(),
            Product_Product = row[27].ToString(),
            Product_Version = row[28].ToString(),
            Product_Level = (decimal)row[29],
            Product_ApprovedDate = (DateTime)row[30],
            ResellerId = row[31].ToString(),
            Product_Retention = (decimal)row[32],
            Product_Rule1 = (decimal)row[33],
            Product_Rule2 = (decimal)row[34],
            Product_Rule3 = (decimal)row[35],
            Product_Method = row[36].ToString(),
            Product_StartDate = (DateTime)row[37],
            Product_Status = (int)row[38],
            Product_StatusString = row[39].ToString(),
            Product_PhoneNo = row[40].ToString(),
            Product_URL = row[41].ToString(),
            ProductType = row[42].ToString()
        };
        return product;
    }

    public static Product Create(BsonDocument row)
    {
        // Removes the _id 
        row.RemoveAt(0);

        Product product = new Product()
        {
            ProductId = Int32.Parse(row.GetElement(0).Value.ToString()),
            ProductTypeId = Int32.Parse(row.GetElement(1).Value.ToString()),
            CompanyId = Int32.Parse(row.GetElement(2).Value.ToString()),
            ManagerId = row.GetElement(3).Value.ToString(),
            AdministratorId = row.GetElement(4).Value.ToString(),
            Product_Interval = Int32.Parse(row.GetElement(5).Value.ToString()),
            AdjustedId = row.GetElement(6).Value.ToString(),
            Product_Comment = row.GetElement(7).Value.ToString(),
            Product_Country = row.GetElement(8).Value.ToString(),
            Currency = row.GetElement(9).Value.ToString(),
            Product_Type = row.GetElement(10).Value.ToString(),
            Product_DescriptionString = row.GetElement(11).Value.ToString(),
            Product_EndDate = Convert.ToDateTime(row.GetElement(12).Value.ToString()),
            Product_ExternalReference = row.GetElement(13).Value.ToString(),
            Product_Price = Convert.ToDecimal(row.GetElement(14).Value.ToString()),
            Product_Parameters = row.GetElement(15).Value.ToString(),
            Product_Interests = row.GetElement(16).Value.ToString(),
            Product_Category = row.GetElement(17).Value.ToString(),
            Product_CommissionPrice = Convert.ToDecimal(row.GetElement(18).Value.ToString()),
            Product_SupplierId = row.GetElement(19).Value.ToString(),
            Product_Rating = Convert.ToDecimal(row.GetElement(20).Value.ToString()),
            Product_Key = row.GetElement(21).Value.ToString(),
            Product_Max = row.GetElement(22).Value.ToString(),
            Product_Name = row.GetElement(23).Value.ToString(),
            Product_Price2 = Convert.ToDecimal(row.GetElement(24).Value.ToString()),
            Product_NoticeLevel = Int32.Parse(row.GetElement(25).Value.ToString()),
            Product_Premium = row.GetElement(26).Value.ToString(),
            Product_Product = row.GetElement(27).Value.ToString(),
            Product_Version = row.GetElement(28).Value.ToString(),
            Product_Level = Convert.ToDecimal(row.GetElement(29).Value.ToString()),
            Product_ApprovedDate = Convert.ToDateTime(row.GetElement(30).Value.ToString()),
            ResellerId = row.GetElement(31).Value.ToString(),
            Product_Retention = Convert.ToDecimal(row.GetElement(32).Value.ToString()),
            Product_Rule1 = Convert.ToDecimal(row.GetElement(33).Value.ToString()),
            Product_Rule2 = Convert.ToDecimal(row.GetElement(34).Value.ToString()),
            Product_Rule3 = Convert.ToDecimal(row.GetElement(35).Value.ToString()),
            Product_Method = row.GetElement(36).Value.ToString(),
            Product_StartDate = Convert.ToDateTime(row.GetElement(37).Value.ToString()),
            Product_Status = Int32.Parse(row.GetElement(38).Value.ToString()),
            Product_StatusString = row[39].ToString(),
            Product_PhoneNo = row.GetElement(40).Value.ToString(),
            Product_URL = row.GetElement(41).Value.ToString(),
            ProductType = row.GetElement(42).Value.ToString(),
        };
        return product;
    }
}
