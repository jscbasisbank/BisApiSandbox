using System;
using Swashbuckle.AspNetCore.Filters;

namespace BisSandboxApi.Web.Models
{
    public class UserExample : IExamplesProvider<User>
    {
        public User GetExamples()
        {
            return new User
            {
                LoginName = "BisUser",
                Password = "Password",
                ClientNo = 2354,
                TicketId = "Ticket"
            };
        }
    }
}

