using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleproject.Models
{
    public class Rolemodel
    {
        public int Role { get; set; }

        [required]
        public string Name { get; set; }
    }
}