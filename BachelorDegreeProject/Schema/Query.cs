using System;
using System.Collections.Generic;
using System.Linq;
using GraphQL.Types;
using System.Threading.Tasks;
using BachelorDegreeProject.Types;
using BachelorProjectBackend.Models;
using BachelorProjectBackend.Repository;
using BachelorProjectAPI.Models;

namespace BachelorDegreeProject.Schema
{
    public class Query : ObjectGraphType
    {
        public Query(Db database)
        {

            Field<ProductObjType>(
                Product.product,
                resolve: context =>
                    {
                        if (database == Db.Mongo)
                        {
                            BachelorProjectBackend.Repository.MongoHandler mongo = new BachelorProjectBackend.Repository.MongoHandler();
                            return mongo.GetProductById(1);
                        }
                        else
                        {
                            BachelorProjectBackend.Repository.MySqlHandler mySql = new BachelorProjectBackend.Repository.MySqlHandler();
                            return mySql.GetProductById(1);
                        }
                    }
                );

            Field<CompanyObjType>(
                Company.company,
                resolve: context =>
                {
                    if(database == Db.Mongo)
                    {
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                });
            Field<DepartmentObjType>(
                Department.department,
                resolve: context =>
                {
                    if (database == Db.Mongo)
                    {
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                });
            Field<PersonObjType>(
                Person.person,
                resolve: context =>
                {
                    if (database == Db.Mongo)
                    {
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                });
            Field<ProductTypeObjType>(
                ProductType.productType,
                resolve: context =>
                {
                    if (database == Db.Mongo)
                    {
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                });
            //    Field<TestType>(
            //Models.test.testObject,
            //arguments: new QueryArguments(
            //    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of test" }
            //),
            //resolve: context =>
            //{
            //    var id = context.GetArgument<string>("id");
            //    var t = BachelorProjectBackend.Repository.Test.Test1().FirstOrDefault(x => x.id == id);
            //    return t;
            //}
            //);
        }

    }
}
