using System;
using System.Threading.Tasks;
using BachelorDegreeProject.Query;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace BachelorDegreeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLMongoController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if(query == null) { throw new ArgumentException(nameof(query)); };
            var inputs = query.Variables.ToInputs();

            var schema = new Schema()
            {
                Query = new Types.TestQuery() // TODO: byt till mongo backend
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ => 
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result.Data);
        }
    }
}