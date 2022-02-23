using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class ChangePasswordRequest
    {
        public string TicketId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string Otp { get; set; }
    }

}
