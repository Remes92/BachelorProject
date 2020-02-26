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
        public TestQuery()
        {

            Field<TestType>(
                Models.test.testObject,
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of test" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<string>("id");
                    var t = BachelorProjectBackend.Repository.Test.Test1().FirstOrDefault(x => x.id == id);
                    return t;
                }
                );
            Field<ListGraphType<TestType>>(
                    Models.test.testList,
                    resolve: context =>
                    {
                        return BachelorProjectBackend.Repository.Test.Test1();
                    }
               );
            //Field<TestType>(
            //        Models.Person.person,
            //        resolve: context =>
            //        {
            //            var id = context.GetArgument<string>("id");
            //            var t = tests.FirstOrDefault(i => i.id == id);
            //            return t;
            //        });
        }
    }
}
