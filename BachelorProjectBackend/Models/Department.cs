using System;
using System.Collections.Generic;
using System.Text;

namespace BachelorProjectBackend.Models
{
    public class Department
    {
        public const string department = "Department";
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public string Department_Description { get; set; }
        public string Department_Key { get; set; }
        public string Department_Label { get; set; }
        public string Department_Name { get; set; }
    }
}
