using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorDegreeProject.Models
{
    public class test
    {
        public const string testObject = "test";
        public const string testList = "tests";

        public test()
        {
            persons = new List<BachelorProjectBackend.Models.Person>();
        }
        public string id { get; set; }
        public string name { get; set; }
        public List<BachelorProjectBackend.Models.Person> persons { get; set; }
    }
}
