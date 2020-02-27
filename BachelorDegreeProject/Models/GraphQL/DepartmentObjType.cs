using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorProjectBackend.Models;

namespace BachelorDegreeProject.Types
{
    public class DepartmentObjType : ObjectGraphType<Department>
    {
        public DepartmentObjType()
        {
            Name = Department.department;
            Field(x => x.DepartmentId, type: typeof(IdGraphType));
            Field(x => x.CompanyId, type: typeof(IntGraphType));
            Field(x => x.Department_Description, type: typeof(StringGraphType));
            Field(x => x.Department_Key, type: typeof(StringGraphType));
            Field(x => x.Department_Label, type: typeof(StringGraphType));
            Field(x => x.Department_Name, type: typeof(StringGraphType));
        }
    }
}
