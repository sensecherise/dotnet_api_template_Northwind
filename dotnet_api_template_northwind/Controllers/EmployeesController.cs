using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Reflection;
using System.Web.Http.Description;
using dotnet_api_template_northwind.Models.BaseModel;
using dotnet_api_template_northwind.Models;
using dotnet_api_template_northwind.BL;

namespace dotnet_api_template_northwind.Controllers
{
    [RoutePrefix("api/NorthwindEmployee")]
    public class EmployeesController : BaseAPIController
    {
        public EmployeesController() { }

        [Route("GetEmpList")]
        [ResponseType(typeof(JSONTemplateListModel<Employees>))]
        [HttpPost]
        public IHttpActionResult GetEmpList()
        {
            JSONTemplateListModel<Employees> response = new JSONTemplateListModel<Employees>()
            {
                Data = null,
                Status = API_Enum.API_STATUS_RESULT.FAIL
            };

            try
            {
                EmployeeManagement Emp = new EmployeeManagement();
                response.Data = Emp.GetEmployeesList();
                response.Status = API_Enum.API_STATUS_RESULT.SUCCESS;
                return JsonResp(response);
            }
            catch(Exception ex)
            {
                response.Message = "Error, Please try again later.";
                return JsonResp(response);
            }
        }
    }
}
