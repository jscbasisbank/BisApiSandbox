using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApi.Web.NewFolder
{
    public class GetReportRequest
    {
        public string TicketId { get; set; }
        public string Account { get; set; }
        public string Ccy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PageNo { get; set; }
    }

}
