using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorProjectBackend.Repository
{
    public class test
    {
        public static List<Models.test> test1() {

             List<Models.test> tests = new List<Models.test> {
                new Models.test { id = "123", name = "test1"},
                new Models.test { id = "1234", name = "test2"},
                new Models.test { id = "12345", name = "test3"}
            };

            return tests;
        }
    }
}
