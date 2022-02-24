using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BisSandboxApi.Web.Models;

public class UploadPackageGelItem
{
    [DataMember]
    [Required]
    public decimal Amount { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAcc { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAccName { get; set; }

    [DataMember]
    public string Descrip { get; set; }

    [DataMember]
    public string TaxPayerTaxCode { get; set; }

    [DataMember]
    public string TaxPayerName { get; set; }

    public int? DocNum { get; set; }
}