using System;
using BisSandboxApi.Web.Models.Requests;
using BisSandboxApi.Web.Models.Responses;

namespace BisSandboxApi.Web.Interfaces;

public interface IMainService
{
    ApiResponse ChangePassword(ChangePasswordRequest request);
    ApiResponse GetReport(GetReportRequest request);
    ApiResponse SendOtp(SendOtpRequest request);
    ApiResponse UploadPackageGel(UploadPackageGelRequest request);
    ApiResponse UploadPackageSalary(UploadPackageSalaryRequest request);
    ApiResponse UploadPackageTreasury(UploadPackageTreasuryRequest request);
    ApiResponse UploadSingleTransfersBatch(UploadSingleTransfersBatchRequest request);
}
