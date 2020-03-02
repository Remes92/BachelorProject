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
        public IActionResult TestCase1() {

            //Models.test test = new Models.test() {id = "1", name = "rolf" };
            return Ok();
        }

        [HttpGet]
        [Route("testcase2")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase2()
        {
            //var test = BachelorProjectBackend.Repository.test.test1();

            MySqlHandler sqlhander = new MySqlHandler();
            var test = sqlhander.GetPersonById(1);

            return Ok();
        }

        [HttpGet]
        [Route("testcase3")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase3()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase4")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase4()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase5")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase5()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase6")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase6()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase7")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase7()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase8")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase8()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase9")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase9()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase10")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase10()
        {


            return Ok();
        }

        [Route("testcase11")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase11()
        {

            //Models.test test = new Models.test() { id = "1", name = "rolf" };
            return Ok();
        }

        [HttpGet]
        [Route("testcase12")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase12()
        {
            //var test = BachelorProjectBackend.Repository.test.test1();

            MySqlHandler sqlhander = new MySqlHandler();
            var test = sqlhander.GetPersonById(1);

            return Ok();
        }

        [HttpGet]
        [Route("testcase13")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase13()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase14")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase14()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase15")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase15()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase16")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase16()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase17")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase17()
        {


            return Ok();
        }

        [HttpGet]
        [Route("testcase18")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase18()
        {


            return Ok();
        }

    }
}