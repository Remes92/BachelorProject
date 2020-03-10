using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorProjectBackend.Models
{
    public class Product
    {
        public const string product = "Product";
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public int CompanyId { get; set; }
        public string ManagerId { get; set; }
        public string AdministratorId { get; set; }
        public int Product_Interval { get; set; }
        public string AdjustedId { get; set; }
        public string Product_Comment { get; set; }
        public string Product_Country { get; set; }
        public string Currency { get; set; }
        public string Product_Type { get; set; }
        public string Product_DescriptionString { get; set; }
        public DateTime Product_EndDate { get; set; }
        public string Product_ExternalReference { get; set; }
        public decimal Product_Price { get; set; }
        public string Product_Interests { get; set; }
        public string Product_Category { get; set; }
        public decimal Product_CommissionPrice { get; set; }
        public string Product_SupplierId { get; set; }
        public decimal Product_Rating { get; set; }
        public string Product_Key { get; set; }
        public string Product_Max { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price2 { get; set; }
        public string Product_Parameters { get; set; }
        public int Product_NoticeLevel { get; set; }
        public string Product_Premium { get; set; }
        public string Product_Product { get; set; }
        public string Product_Version { get; set; }
        public decimal Product_Level { get; set; }
        public DateTime Product_ApprovedDate { get; set; }
        public string ResellerId { get; set; }
        public decimal Product_Retention { get; set; }
        public decimal Product_Rule1 { get; set; }
        public decimal Product_Rule2 { get; set; }
        public decimal Product_Rule3 { get; set; }
        public string Product_Method { get; set; }
        public DateTime Product_StartDate { get; set; }
        public int Product_Status { get; set; }
        public string Product_StatusString { get; set; }
        public string Product_PhoneNo { get; set; }
        public string Product_URL { get; set; }
        public string ProductType { get; set; }
        public ProductType productTypeObject { get; set; }
        public Company companyObject { get; set; }
    }
}
