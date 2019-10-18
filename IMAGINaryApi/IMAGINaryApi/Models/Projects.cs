using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAGINaryApi.Models
{
    public class Projects
    {
        public string Project { get; set; }
        public string Developer { get; set; }
        public long Hours { get; set; }
        public long Overtime { get; set; }
        public string Contribution { get; set; }
    }
}