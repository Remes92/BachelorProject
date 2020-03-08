using System;
using System.Threading.Tasks;
using BachelorDegreeProject.Query;
using GraphQL;
using Microsoft.AspNetCore.Mvc;
using BachelorProjectAPI.Models;

namespace BachelorDegreeProject.Controllers
{
    [Route("api/[controller]")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class GraphQLMySqlController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new GraphQL.Types.Schema()
            {
                Query = new Schema.Query(Db.MySql)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            if(result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result.Data);
        }
    }
}