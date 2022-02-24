using System;
using System.Text.RegularExpressions;
using BisSandboxApi.Web.Constants;
using BisSandboxApi.Web.Interfaces;
using BisSandboxApi.Web.Models;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;

namespace BisSandboxApi.Web.Services;

public class MainService : IMainService
{
    public ApiResponse ChangePassword(ChangePasswordRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        else if (!IsCorrectPasssword(request.OldPassword, ref response))
        {
            return response;
        }

        else if (!IsCorrectOtp(request.Otp, ref response))
        {
            return response;
        }

        return response;
    }

    public ApiResponse SendOtp(SendOtpRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        return response;
    }

    public ApiResponse UploadPackageGel(UploadPackageGelRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        else if (!IsCorrectAccount(request.SenderAcc, ref response))
        {
            return response;
        }

        else if (!IsCorrectOtp(request.Otp, ref response))
        {
            return response;
        }

        foreach (var item in request.PackageItems)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        return response;
    }

    public ApiResponse UploadPackageSalary(UploadPackageSalaryRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        else if (!IsCorrectAccount(request.SenderAcc, ref response))
        {
            return response;
        }

        else if (!IsCorrectOtp(request.Otp, ref response))
        {
            return response;
        }

        foreach (var item in request.PackageItems)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        return response;
    }

    public ApiResponse UploadPackageTreasury(UploadPackageTreasuryRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        else if (!IsCorrectAccount(request.SenderAcc, ref response))
        {
            return response;
        }

        else if (!IsCorrectOtp(request.Otp, ref response))
        {
            return response;
        }

        foreach (var item in request.PackageItems)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        return response;
    }

    public ApiResponse UploadSingleTransfersBatch(UploadSingleTransfersBatchRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectTicketId(request.TicketId, ref response))
        {
            return response;
        }

        else if (!IsCorrectOtp(request.Otp, ref response))
        {
            return response;
        }

        foreach (var item in request.InternalTransfers)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        foreach (var item in request.ForeignCurrencyTransfers)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        foreach (var item in request.TreasuryTransfers)
        {
            if (item.TreasuryCode.ToUpper() != "TRESGE22")
            {
                response.ErrorCode = -1;
                response.ErrorMsg = "Invalid treasury code";

                return response;
            }
        }

        foreach (var item in request.NationalCurrencyTransfers)
        {
            if (!IsCorrectIban(item.ReceiverAcc, ref response))
            {
                return response;
            }
        }

        return response;
    }

    public ApiResponse GetReport(GetReportRequest request)
    {
        var response = new ApiResponse();

        if (!IsCorrectAccount(request.Account, ref response))
        {
            return response;
        }

        return response;
    }

    private static bool IsCorrectIban(string accountIban, ref ApiResponse response)
    {
        string prefix = accountIban.Substring(0, 2);
        string bankCode = accountIban.Substring(4, 2);
        string rest = accountIban[6..];

        if (accountIban.Length == 22 && prefix == "GE" && Regex.IsMatch(rest, "^[0-9]+$") && BankCodes.Banks.ContainsKey(bankCode))
        {
            return true;
        }

        response.ErrorCode = -1;
        response.ErrorMsg = "Invalid receiver account";

        return false;
    }

    private static bool IsCorrectTicketId(string ticketId, ref ApiResponse response)
    {
        if (User.BisUser.TicketId == ticketId)
        {
            return true;
        }

        response.ErrorCode = -1;
        response.ErrorMsg = "Invalid session";

        return false;
    }

    private static bool IsCorrectAccount(string accIban, ref ApiResponse response)
    {
        if (User.BisUser.Account == accIban)
        {
            return true;
        }

        response.ErrorCode = -1;
        response.ErrorMsg = "Invalid sender account iban";

        return false;
    }

    private static bool IsCorrectPasssword(string password, ref ApiResponse response)
    {
        if (User.BisUser.Password == password)
        {
            return true;
        }

        response.ErrorCode = -1;
        response.ErrorMsg = "Invalid password";

        return false;
    }

    private static bool IsCorrectOtp(string otp, ref ApiResponse response)
    {
        if (User.BisUser.Otp == otp)
        {
            return true;
        }

        response.ErrorCode = -1;
        response.ErrorMsg = "Invalid OTP";

        return false;
    }
}