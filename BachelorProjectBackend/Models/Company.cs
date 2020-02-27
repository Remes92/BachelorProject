using System;
using System.Collections.Generic;
using System.Text;

namespace BachelorProjectBackend.Models
{
    public class Company
    {
        public const string company = "Company";
        public int CompanyId { get; set; }
        public string Company_Name { get; set; }
        public bool Company_DirectionIn { get; set; }
        public bool Company_DirectionOut { get; set; }
        public string Company_Phone { get; set; }
        public string Company_Label { get; set; }
        public string Company_Slogan { get; set; }
    }
}
