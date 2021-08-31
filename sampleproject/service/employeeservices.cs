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
    public class employeeservices
    {
        public string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        private sqldataadapter _adapter;
        private dataset _ds;


        public IList<employeemodel> Getemplist()
        {

            IList<employeemodel> getemplist = new List<employeemodel>();
            _ds = new dataset();
            using(SqlConnection con = new sqlconnection(connect))

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("employeevieworinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mode", "getemplist");
                _adapter = new sqldataadapter(cmd);
                _adapter.fill(_ds);
                if (_ds.tables.count > 0)
                {
                    return (List<employeemodel>)getemplist;




                }
                else
                {
                }
                for (int i = 0; i < _ds.tables[0].rows.count; i++)
                {
                    employeemodel obj = new employeemodel();
                    obj.id = Convert.ToString(_ds.tables[0].rows[i]["id"]);
                    obj.firstname = Convert.ToString(_ds.tables[0].rows[i]["firstname"]);
                    obj.lastname = Convert.ToString(_ds.tables[0].rows[i]["lastname"]);
                    obj.dob = Convert.ToString(_ds.tables[0].rows[i]["dob"]);
                    obj.contact = Convert.ToString(_ds.tables[0].rows[i]["contact"]);
                    obj.roleid = Convert.ToString(_ds.tables[0].rows[i]["roleid"]);
                    getemplist.Add(obj);


                }






                return (List<employeemodel>)getemplist;




            }






            return (List<employeemodel>)getemplist;

        }

     



        public void insertemployee(employeemodel model)
     
        {

            using (sqlconnection con = new sqlconnection(connect))
            {
                SqlCommand cmd = new SqlCommand("employeevieworinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mode", "AddEmployee");
                cmd.Parameters.AddWithValue("@firstname", model.firstname);
                cmd.Parameters.AddWithValue("@lastname", model.lastname);
                cmd.Parameters.AddWithValue("@dob", model.dob);
                cmd.Parameters.AddWithValue("@contact", model.contact);
                cmd.ExecuteNonQuery();

            }





        }



        public employeemodel Geteditbyid(int id)
        {
            var model = new employeemodel();
            using(sqlconnection con = = new sqlconnection(connect))

            {
                con.open();



            }







        }













    }
}