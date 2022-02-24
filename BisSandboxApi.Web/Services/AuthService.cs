using System;
using BisSandboxApi.Web.Interfaces;
using BisSandboxApi.Web.Models;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;

namespace BisSandboxApi.Web.Services;

public class AuthService : IAuthService
{
    public ApiResponse LogIn(AuthRequest request)
    {
        var response = new ApiResponse();

        if (request.LoginName.ToUpper() == User.BisUser.LoginName.ToUpper() && request.Password == User.BisUser.Password)
        {
            response.ErrorCode = 0;
            response.Data = $"clientNo : {User.BisUser.ClientNo}";
        }

        else
        {
            response.ErrorCode = -1;
            response.ErrorMsg = "Invalid username or password";
        }

        if (!IsCorrectLanguage(request.Lang))
        {
            response.ErrorCode = -1;
            response.ErrorMsg = "Language not supported. Use 'GE' or 'EN'";
        }

        return response;
    }

    public ApiResponse LogOut(LogOutRequest request)
    {
        var response = new ApiResponse();

        if (request.TicketId == User.BisUser.TicketId)
        {
            response.ErrorCode = 0;
        }

        else
        {
            response.ErrorCode = -1;
            response.ErrorMsg = "Invalid sesion";
        }

        return response;
    }

    private static bool IsCorrectLanguage(string lang)
    {
        if (lang.ToUpper() != "GE" || lang.ToUpper() != "EN")
        {
            return false;
        }

        return true;
    }
}
