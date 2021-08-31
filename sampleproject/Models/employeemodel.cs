using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleproject.Models
{
    public class employeemodel
    {

        public int id { get; set; }
        
        [required]
        public string firstname { get; set; }

        [required]
        public string lastname { get; set; }

        [required]
        public DateTime dob { get; set; }

        [required]
        public long Contact { get; set; }
       
        [required]
        public int roleid { get; set; }

      


    }

    internal class requiredAttribute : Attribute
    {
    }
}