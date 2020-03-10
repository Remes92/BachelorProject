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
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id"}
                ),
                resolve: context =>
                    {
                        var id = context.GetArgument<int>("id");
                        if (database == Db.Mongo)
                        {
                            MongoHandler mongo = new MongoHandler();
                            return mongo.GetProductById(id);
                        }
                        else
                        {
                            MySqlHandler mySql = new MySqlHandler();
                            return mySql.GetProductById(id);
                        }
                    }
                );
            Field<ListGraphType<ProductObjType>>(
                "products",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "lower" },
                    new QueryArgument<IdGraphType> { Name = "upper" }
                ),

                resolve: context =>
                {
                    var lower = context.GetArgument<int>("lower");
                    var upper = context.GetArgument<int>("upper");
                    if (database == Db.Mongo)
                    {
                        MongoHandler mongo = new MongoHandler();
                        return mongo.GetProductById(lower,upper);
                    }
                    else
                    {
                        MySqlHandler mySql = new BachelorProjectBackend.Repository.MySqlHandler();
                        return mySql.GetProductById(lower, upper);
                    }
                });


            Field<ProductObjType>(
                "productAndType",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id" }
                ),
                resolve: context =>
                    {
                        var id = context.GetArgument<int>("id");
                        if (database == Db.Mongo)
                        {
                            MongoHandler mongo = new MongoHandler();
                            return mongo.GetProductJoinProductTypeById(id);
                        }
                        else
                        {
                            MySqlHandler mySql = new MySqlHandler();
                            return mySql.GetProductJoinProductTypeById(id);
                        }
                    }
                );

            Field<ListGraphType<ProductObjType>>(
                "productsAndTypes",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "lower" },
                    new QueryArgument<IdGraphType> { Name = "upper" }
                ),

                resolve: context =>
                {
                    var lower = context.GetArgument<int>("lower");
                    var upper = context.GetArgument<int>("upper");
                    if (database == Db.Mongo)
                    {
                        MongoHandler mongo = new MongoHandler();
                        return mongo.GetProductJoinProductTypeById(lower,upper);
                    }
                    else
                    {
                        MySqlHandler mySql = new BachelorProjectBackend.Repository.MySqlHandler();
                        return mySql.GetProductJoinProductTypeById(lower, upper);
                    }
                });

            Field<ProductObjType>(
                "productAndTypeAndCompany",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id" }
                ),

                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    if (database == Db.Mongo)
                    {
                        MongoHandler mongo = new MongoHandler();
                        return mongo.GetProductJoinProductTypeAndCompanyById(id);
                    }
                    else
                    {
                        MySqlHandler mySql = new BachelorProjectBackend.Repository.MySqlHandler();
                        return mySql.GetProductJoinProductTypeAndCompanyById(id);
                    }
                });

            Field<ListGraphType<ProductObjType>>(
                "productsAndTypesAndCompanys",
                 arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "lower" },
                    new QueryArgument<IdGraphType> { Name = "upper" }
                ),

                resolve: context =>
                {
                    var lower = context.GetArgument<int>("lower");
                    var upper = context.GetArgument<int>("upper");
                    if (database == Db.Mongo)
                    {
                        MongoHandler mongo = new MongoHandler();
                        return mongo.GetProductJoinProductTypeAndCompanyById(lower,upper);
                    }
                    else
                    {
                        MySqlHandler mySql = new BachelorProjectBackend.Repository.MySqlHandler();
                        return mySql.GetProductJoinProductTypeAndCompanyById(lower, upper);
                    }
                });



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
                arguments: new QueryArguments(
                    new QueryArgument<IdGraphType> { Name = "id" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    if (database == Db.Mongo)
                    {
                        MongoHandler mongo = new MongoHandler();
                        return mongo.GetProductJoinProductTypeById(id);
                    }
                    else
                    {
                        MySqlHandler mySql = new MySqlHandler();
                        return mySql.GetProductJoinProductTypeById(id);
                    }
                
                });
        }

    }
}
