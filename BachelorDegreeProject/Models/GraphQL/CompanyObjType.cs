using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorProjectBackend.Models;

namespace BachelorDegreeProject.Types
{
    public class CompanyObjType : ObjectGraphType<Company>
    {
        public CompanyObjType()
        {
            Name = Company.company;
            Field(x => x.CompanyId, type: typeof(IdGraphType));
            Field(x => x.Company_Name, type: typeof(StringGraphType));
            Field(x => x.Company_DirectionIn, type: typeof(BooleanGraphType));
            Field(x => x.Company_DirectionOut, type: typeof(BooleanGraphType));
            Field(x => x.Company_Phone, type: typeof(StringGraphType));
            Field(x => x.Company_Label, type: typeof(StringGraphType));
            Field(x => x.Company_Slogan, type: typeof(StringGraphType));
        }
    }
}
