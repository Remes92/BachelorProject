using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BachelorDegreeProject.Types
{
    public class PersonType : ObjectGraphType<Models.Person>
    {
        public PersonType()
        {
            Name = "person";
            Field(x => x.id, type: typeof(IdGraphType)).Description("The test ID.");
            Field(x => x.name, type: typeof(StringGraphType)).Description("test name");
            Field(x => x.age, type: typeof(IntGraphType));

        }
    }
}
