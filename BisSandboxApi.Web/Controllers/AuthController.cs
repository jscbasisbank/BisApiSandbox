using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisSandboxApi.Web.Interfaces;
using BisSandboxApi.Web.Models;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace BisSandboxApi.Web.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Consumes("application/json")]
[Produces("application/json")]
public class AuthController : Controller
{
    private readonly IAuthService _service;

    public AuthController(IAuthService service)
    {
        _service = service;
    }

    /// <summary>
    /// Returns BisUser details
    /// </summary>
    [HttpGet]
    public ApiResponse Seed()
    {
        var response = new ApiResponse();

        response.ErrorCode = 200;
        response.Data = Models.User.BisUser;
        return response;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /LogIn
    ///     {
    ///        "loginName": "BisUser",
    ///        "password": "Password",
    ///        "lang": "GE"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse LogIn([FromBody] AuthRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.LogIn(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /LogOut
    ///     {
    ///         "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse LogOut([FromBody] LogOutRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.LogOut(request);
    }
}

