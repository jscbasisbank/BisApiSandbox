using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class ApiResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public object Data { get; set; }
    }
}
