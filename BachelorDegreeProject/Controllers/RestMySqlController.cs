using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BachelorProjectBackend.Repository;
using BachelorProjectBackend.Models;

namespace BachelorDegreeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestMySqlController : ControllerBase
    {
        [Route("testcase1")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase1(int id) {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase2")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase2(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase3")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase3(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase4")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase4(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower,upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase5")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase5(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower,upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase6")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase6(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower,upper);
            return Ok(products);
        }

        [Route("testcase7")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase7(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase8")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase8(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase9")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase9(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase10")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase10(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower, upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase11")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase11(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower, upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase12")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase12(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return Ok(products);
        }

        [Route("testcase13")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase13(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase14")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase14(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase15")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase15(int id)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            Product product = sqlhander.GetProductJoinProductTypeAndCompanyById(id);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase16")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase16(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductJoinProductTypeById(lower, upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase17")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase17(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var product = sqlhander.GetProductById(lower, upper);
            return Ok(product);
        }

        [HttpGet]
        [Route("testcase18")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestCase18(int lower, int upper)
        {
            MySqlHandler sqlhander = new MySqlHandler();
            var products = sqlhander.GetProductJoinProductTypeAndCompanyById(lower, upper);
            return Ok(products);
        }
    }
}