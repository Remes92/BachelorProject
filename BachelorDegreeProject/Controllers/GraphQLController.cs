using System;
using System.Threading.Tasks;
using BachelorDegreeProject.Query;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace BachelorDegreeProject.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new Types.TestQuery()
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if(result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result.Data);
        }
    }
}