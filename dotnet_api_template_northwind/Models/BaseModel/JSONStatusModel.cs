using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnet_api_template_northwind.Models.BaseModel
{
    public class JSONStatusModel
    {
        public JSONStatusModel()
        {
                this.Message = "";
                this.Status = API_Enum.API_STATUS_RESULT.FAIL;
        }
        public string Message { get; set; }
        public API_Enum.API_STATUS_RESULT Status { get; set; }
    }

    public class JSONTemplateModel<T>
    {
        public JSONTemplateModel()
        {
            this.Data = default(T);
            this.Message = "";
            this.Status = API_Enum.API_STATUS_RESULT.FAIL;
        }
        public string Message { get; set; }
        public T Data { get; set; }
        public API_Enum.API_STATUS_RESULT Status { get; set; }
    }

    public class JSONTemplateListModel<T>
    {
        public JSONTemplateListModel()
        {
            this.Data = null;
            this.Message = "";
            this.Status = API_Enum.API_STATUS_RESULT.FAIL;
        }
        public string Message { get; set; }
        public API_Enum.API_STATUS_RESULT Status { get; set; }
        public int TotalItemCount
        {
            get
            {
                return null != Data ? Data.Count() : 0;
            }
        }

        public List<T> Data { get; set; }
    }
}