﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorDegreeProject.Types;
using GraphQL.Types;

namespace BachelorDegreeProject.Models.GraphQL
{
    public class TestType : ObjectGraphType<BachelorProjectBackend.Models.test>
    {
        public TestType()
        {
            Name = "Test";

            Field(x => x.id!, type: typeof(IdGraphType)).Description("The test ID.");
            Field(x => x.name).Description("test name");
            Field<ListGraphType<PersonType>>("persons");
        }
    }
}