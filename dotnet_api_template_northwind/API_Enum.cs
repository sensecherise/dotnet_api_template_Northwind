using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel; //Add DescriptionAttribute

namespace dotnet_api_template_northwind
{
    public class API_Enum
    {
        public enum API_STATUS_RESULT
        {
            [DescriptionAttribute("Success")]
            SUCCESS = 1,

            [DescriptionAttribute("Fail")]
            FAIL = 2
        }
    }
}