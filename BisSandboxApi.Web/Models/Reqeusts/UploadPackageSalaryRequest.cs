﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BisSandboxApi.Web.Models.Requests;

public class UploadPackageSalaryRequest : BaseRequest
{
    [DataMember]
    [Required]
    [StringLength(22)]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    public string PackageName { get; set; }

    [DataMember]
    [Required]
    public string Otp { get; set; }

    [DataMember]
    [Required]
    public List<UploadPackageGelItem> PackageItems { get; set; }
}