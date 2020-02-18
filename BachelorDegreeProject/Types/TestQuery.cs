using BachelorDegreeProject.Models.GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorDegreeProject.Types
{
    public class TestQuery : ObjectGraphType
    {
            private List<Models.test> tests = new List<Models.test>
            {
                new Models.test { id = "123", name = "test1"},
                new Models.test { id = "1234", name = "test2"},
                new Models.test { id = "12345", name = "test2"},
            };
        public TestQuery()
        {

            Field<TestType>(
                Models.test.graphqlmodel,
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of test"},
                    new QueryArgument<IdGraphType> { Name = "name", Description = "The NAME of test" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<string>("id");
                    var t = tests.FirstOrDefault(i => i.id == id);
                    return t;
                }
                );;

                Field<ListGraphType<TestType>>(
                    "tests",
                    resolve: context =>
                    {
                        return tests;
                    }
               );
        }
    }
}
