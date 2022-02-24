using System;
using BisSandboxApi.Web.Models;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;

namespace BisSandboxApi.Web.Interfaces;

public interface IAuthService
{
    ApiResponse LogIn(AuthRequest request);
    ApiResponse LogOut(LogOutRequest request);
}