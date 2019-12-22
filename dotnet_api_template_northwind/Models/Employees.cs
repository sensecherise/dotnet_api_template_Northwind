﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnet_api_template_northwind.Models
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public HttpPostedFileBase Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }

    }
}