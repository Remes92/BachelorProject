using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorProjectBackend.Models
{
    public class test
    {
        public test()
        {
            persons = new List<Person>();
        }
        public string id { get; set; }
        public string name { get; set; }
        public List<Person> persons { get; set; }
    }
}
