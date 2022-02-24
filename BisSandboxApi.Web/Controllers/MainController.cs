using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisSandboxApi.Web.Interfaces;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BisSandboxApi.Web.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
[Consumes("application/json")]
[Produces("application/json")]
public class MainController : Controller
{
    private readonly IMainService _service;

    public MainController(IMainService service)
    {
        _service = service;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /ChangePassword
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "oldPassword": "Password",
    ///        "newPassword": "NewPass!",
    ///        "otp": "111111"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse ChangePassword([FromBody] ChangePasswordRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.ChangePassword(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /SendOtp
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse SendOtp([FromBody] SendOtpRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.SendOtp(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /UploadaPackageGel
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "senderAcc": "GE74BS0000000000736222",
    ///        "packageName": "Gel",
    ///        "otp": "111111",
    ///        "packageItems":
    ///        [
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა",
    ///                 "taxPayerTaxCode": "01234567890",
    ///                 "taxPayerName": "Giorgi Ratiani"
    ///             },
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა"
    ///             }
    ///        ]
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse UploadPackageGel([FromBody] UploadPackageGelRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.UploadPackageGel(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /UploadPackageSalary
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "senderAcc": "GE74BS0000000000736222",
    ///        "packageName": "Salary",
    ///        "otp": "111111",
    ///        "packageItems":
    ///        [
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა",
    ///                 "taxPayerTaxCode": "01234567890",
    ///                 "taxPayerName": "Giorgi Ratiani"
    ///             },
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა"
    ///             }
    ///        ]
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse UploadPackageSalary([FromBody] UploadPackageSalaryRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.UploadPackageSalary(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /UploadPackageTreasury
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "senderAcc": "GE74BS0000000000736222",
    ///        "packageName": "Treasury",
    ///        "otp": "111111",
    ///        "packageItems":
    ///        [
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა",
    ///                 "taxPayerTaxCode": "01234567890",
    ///                 "taxPayerName": "Giorgi Ratiani"
    ///             },
    ///             {
    ///                 "amount": 60.6,
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze",
    ///                 "descrip": "პირადი გადარიცხვა"
    ///             }
    ///        ]
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse UploadPackageTreasury([FromBody] UploadPackageTreasuryRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.UploadPackageTreasury(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /UploadSingleTransfersBatch
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "otp": "111111",
    ///        "internalTransfers":
    ///        [
    ///             {
    ///                 "senderAcc": "GE74BS0000000000736222",
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "amount": 60.6,
    ///                 "descrip": "პირადი გადარიცხვა"
    ///             }
    ///        ],
    ///        "nationalCurrencyTransfers":
    ///        [
    ///             {
    ///                 "senderAcc": "GE74BS0000000000736222",
    ///                 "receiverAcc": "GE74BS0000000000736225",
    ///                 "receiverAccName": "Tamar Jokhadze","
    ///                 "receiverBankCode": "TBC",
    ///                 "amount": 60.6,
    ///                 "descrip": "პირადი გადარიცხვა",
    ///                 "taxPayerTaxCode": "01234567890",
    ///                 "taxPayerName": "Giorgi Ratiani"
    ///             }
    ///        ],
    ///        "foreignCurrencyTransfers":
    ///        [
    ///             {
    ///                 "senderAcc": "GE74BS0000000000736222",
    ///                 "ccy": "GBP",
    ///                 "receiverAcc": "BARCGB5G0000000000736225",
    ///                 "receiverAddress": "Baker Street 221b",
    ///                 "receiverAccName": "Tamar Jokhadze","
    ///                 "receiverBankCode": "BARCGB5GXXX",
    ///                 "receiverBankName": "Barclays"
    ///                 "amount": 60.6,
    ///                 "descrip": "Foreign payment",
    ///                 "extralInfo": "Study fee"
    ///             }
    ///        ],
    ///        "treasuryTransfers":
    ///        [
    ///             {
    ///                 "senderAcc": "GE74BS0000000000736222",
    ///                 "treasuryCode": "TRESGE22",
    ///                 "amount": 60.6,
    ///                 "taxPayerTaxCode": "01234567890",
    ///                 "taxPayerName": "Giorgi Ratiani",
    ///                 "extraInfo": "სწავლის საფასური"
    ///             },
    ///             {
    ///                 "senderAcc": "GE74BS0000000000736222",
    ///                 "treasuryCode": "TRESGE22",
    ///                 "amount": 60.6,
    ///                 "extraInfo": "სწავლის საფასური"
    ///             }
    ///        ]
    ///     }
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse UploadSingleTransfersBatch([FromBody] UploadSingleTransfersBatchRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.UploadSingleTransfersBatch(request);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /GetReport
    ///     {
    ///        "ticketId": "bank-integration-service%5B%7C%5D121701%5B%7C%5D03848DC5-7DB6-44A0-B654-74A1ADBCDEBC%5B%7C%5D50fa4ac65c915cd65a15ebc3d089d5b254237f4d8e638d95d4972eec1f20017ecb5316a20c30d6396e7950a5d9e3d31ebe31ddea9b8aaecb5b063bee1ab632e7bab3f73f2588f05adb55e72a757c519ce8b6b1fdf62a361891492e2b90205bd5571e6d0595c01119e7aa16e80b562a7ef18e3e7cde11d569479b0ff31f7ea9f3%5B%7C%5D2%2F22%2F2022+5%3A19%3A12+PM%5B%7C%5D1b63ce53d62e223d137557f5e834b5b19638b20c2d7c29a5c4ede0e3d1616b3f636cfdd6e3b8b5d732d19e3b0e74c911a03d457d310fc3c7adc1d2d5c5ce281bc17cc90820f5907523e35b65da1b9c94177730d9d4405375f137476e499997f34adcbebef401eae280977c0b9fd3d3917433aea17958d2321e15b2a55e2a489f",
    ///        "account": "GE74BS0000000000736222",
    ///        "ccy": "GEL",
    ///        "startDate": "2022-02-22T12:31:43.818Z",
    ///        "endDate": "2022-02-28T12:31:43.818Z"
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returned in every case</response>
    [HttpPost]
    public ApiResponse GetReport([FromBody] GetReportRequest request)
    {
        if (!ModelState.IsValid)
        {
            return new ApiResponse() { ErrorCode = 1, ErrorMsg = "შეავსეთ ყველა სავალდებულო ველი" };
        }

        return _service.GetReport(request);
    }
}
