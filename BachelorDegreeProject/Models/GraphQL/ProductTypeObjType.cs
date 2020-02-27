using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorProjectBackend.Models;

namespace BachelorDegreeProject.Types
{
    public class ProductTypeObjType : ObjectGraphType<ProductType>
    {
        public ProductTypeObjType()
        {
            Name = ProductType.productType;
            Field(x => x.ProductTypeId, type: typeof(IdGraphType));
            Field(x => x.ProductType_DescriptionString, type: typeof(StringGraphType));
            Field(x => x.ProductType_KeySellingPoint, type: typeof(StringGraphType));
            Field(x => x.ProductType_Label, type: typeof(StringGraphType));
            Field(x => x.ProductType_Name, type: typeof(StringGraphType));
            Field(x => x.ProductType_Status, type: typeof(IntGraphType));
        }
    }
}
