using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BachelorProjectBackend.Repository;

namespace BachelorDegreeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestMySqlController : ControllerBase
    {
        [Route("testcase1")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult testCase1() {

            Models.test test = new Models.test() {id = "1", name = "rolf" };
            return Ok(test);
        }

        [HttpGet]
        [Route("testcase2")]
        public IActionResult testCase2()
        {
            //var test = BachelorProjectBackend.Repository.test.test1();

            MySqlHandler sqlhander = new MySqlHandler();
            var test = sqlhander.getPersonById(1);

            return Ok();
        }

        [HttpGet]
        [Route("testcase3")]
        public IActionResult testCase3()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase4")]
        public IActionResult testCase4()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase5")]
        public IActionResult testCase5()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase6")]
        public IActionResult testCase6()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase7")]
        public IActionResult testCase7()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase8")]
        public IActionResult testCase8()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase9")]
        public IActionResult testCase9()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase10")]
        public IActionResult testCase10()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase10_2")]
        public IActionResult testCase10_2()
        {


            return Ok();
        }

    }
}