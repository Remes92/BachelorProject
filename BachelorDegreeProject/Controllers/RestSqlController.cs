using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BachelorDegreeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestSqlController : ControllerBase
    {
        [Route("testcase1")]
        [HttpGet]
        public IActionResult testCase1() {
            var test = BachelorProjectBackend.Repository.test.test1();

            return Ok(test);
        }

        [HttpGet]
        [Route("testcase2")]
        public IActionResult testCase2()
        {


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