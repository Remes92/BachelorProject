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
                new Models.test { id = "123", name = "test1", persons = { new Models.Person() {id = "1",age = 13, name = "kalle" }, new Models.Person() { id = "4", age = 40, name = "Rolf" } } },
                new Models.test { id = "1234", name = "test2", persons = { new Models.Person() {id = "2",age = 10, name = "klas" } } },
                new Models.test { id = "12345", name = "test2", persons = { new Models.Person() {id = "3",age = 20, name = "johan" }} },
            };
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
                    var t = tests.FirstOrDefault(i => i.id == id);
                    return t;
                }
                );
            Field<ListGraphType<TestType>>(
                    Models.test.testList,
                    resolve: context =>
                    {
                        return tests;
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
