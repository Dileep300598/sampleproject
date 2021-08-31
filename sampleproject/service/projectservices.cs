using sampleproject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace sampleproject.service
{
    public class projectservices
    {

        public string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        private SqlDataAdapter _adapter;
        private DataSet _ds;

        public IList<Projectmodel> Getprojectlist()
        {
            IList<Projectmodel>





        }


    }
}