using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dotnet_api_template_northwind.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace dotnet_api_template_northwind.BL
{
    public class EmployeeManagement
    {

        public static string _CON_NORTHWIND = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        public EmployeeManagement()
        {

        }

        public List<Employees> GetEmployeesList()
        {
            List<Employees> listemp = new List<Employees>();
            

            using(SqlConnection db = new SqlConnection(_CON_NORTHWIND))
            {
                SqlCommand cmd = new SqlCommand("[spEmployees_Management]", db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", "getEmpList");


                SqlDataAdapter da = new SqlDataAdapter();
                if (db.State == ConnectionState.Closed) db.Open();

                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                foreach(DataRow row in dt.Rows)
                {
                    Employees emp = new Employees();
                    emp.EmployeeID = Int32.Parse(row["EmployeeID"].ToString()); 
                    emp.LastName = row["LastName"].ToString();
                    emp.FirstName = row["FirstName"].ToString();
                    emp.Title = row["Title"].ToString();

                    listemp.Add(emp);
                }
            }

            return listemp;
        }


    }
}