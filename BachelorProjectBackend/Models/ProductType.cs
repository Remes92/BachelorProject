using System;
using System.Collections.Generic;
using System.Text;

namespace BachelorProjectBackend.Models
{
    public class ProductType
    {
        public const string productType = "productType";
        public int ProductTypeId { get; set; }
        public string ProductType_DescriptionString { get; set; }
        public string ProductType_KeySellingPoint { get; set; }
        public string ProductType_Label { get; set; }
        public string ProductType_Name { get; set; }
        public int ProductType_Status { get; set; }
    }
}
