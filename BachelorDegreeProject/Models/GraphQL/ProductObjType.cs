using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorProjectBackend.Models;

namespace BachelorDegreeProject.Types
{
    public class ProductObjType : ObjectGraphType<Product>
    {
        public ProductObjType()
        {
            Name = Product.product;
            Field(x => x.ProductId, type: typeof(IdGraphType));
            Field(x => x.ProductTypeId, type: typeof(IntGraphType));
            Field(x => x.CompanyId, type: typeof(IntGraphType));
            Field(x => x.ManagerId, type: typeof(StringGraphType));
            Field(x => x.AdministratorId, type: typeof(StringGraphType));
            Field(x => x.Product_Interval, type: typeof(IntGraphType));
            Field(x => x.AdjustedId, type: typeof(StringGraphType));
            Field(x => x.Product_Comment, type: typeof(StringGraphType));
            Field(x => x.Product_Country, type: typeof(StringGraphType));
            Field(x => x.Currency, type: typeof(StringGraphType));
            Field(x => x.Product_Type, type: typeof(StringGraphType));
            Field(x => x.Product_DescriptionString, type: typeof(StringGraphType));
            Field(x => x.Product_EndDate, type: typeof(DateTimeGraphType));
            Field(x => x.Product_ExternalReference, type: typeof(StringGraphType));
            Field(x => x.Product_Price, type: typeof(DecimalGraphType));
            Field(x => x.Product_Interests, type: typeof(StringGraphType));
            Field(x => x.Product_Category, type: typeof(StringGraphType));
            Field(x => x.Product_CommissionPrice, type: typeof(DecimalGraphType));
            Field(x => x.Product_SupplierId, type: typeof(StringGraphType));
            Field(x => x.Product_Rating, type: typeof(DecimalGraphType));
            Field(x => x.Product_Key, type: typeof(StringGraphType));
            Field(x => x.Product_Max, type: typeof(StringGraphType));
            Field(x => x.Product_Name, type: typeof(StringGraphType));
            Field(x => x.Product_Price2, type: typeof(DecimalGraphType));
            Field(x => x.Product_Parameters, type: typeof(StringGraphType));
            Field(x => x.Product_NoticeLevel, type: typeof(IntGraphType));
            Field(x => x.Product_Premium, type: typeof(StringGraphType));
            Field(x => x.Product_Product, type: typeof(StringGraphType));
            Field(x => x.Product_Version, type: typeof(StringGraphType));
            Field(x => x.Product_Level, type: typeof(DecimalGraphType));
            Field(x => x.Product_ApprovedDate, type: typeof(DateTimeGraphType));
            Field(x => x.ResellerId, type: typeof(StringGraphType));
            Field(x => x.Product_Retention, type: typeof(DecimalGraphType));
            Field(x => x.Product_Rule1, type: typeof(DecimalGraphType));
            Field(x => x.Product_Rule2, type: typeof(DecimalGraphType));
            Field(x => x.Product_Rule3, type: typeof(DecimalGraphType));
            Field(x => x.Product_Method, type: typeof(StringGraphType));
            Field(x => x.Product_StartDate, type: typeof(DateTimeGraphType));
            Field(x => x.Product_Status, type: typeof(IntGraphType));
            Field(x => x.Product_StatusString, type: typeof(StringGraphType));
            Field(x => x.Product_PhoneNo, type: typeof(StringGraphType));
            Field(x => x.Product_URL, type: typeof(StringGraphType));
            Field(x => x.ProductType, type: typeof(StringGraphType));
            Field(x => x.productTypeObject, type: typeof(ProductObjType));
            Field(x => x.companyObject, type: typeof(CompanyObjType));
        }
    }
}
