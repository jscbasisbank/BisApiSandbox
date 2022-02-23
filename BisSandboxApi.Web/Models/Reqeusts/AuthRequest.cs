using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class AuthRequest
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Lang { get; set; }
    }

}
