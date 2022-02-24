using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BisSandboxApi.Web.Models;

public class TransferBatchTreasury
{
    [DataMember]
    [Required]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    public string TreasuryCode { get; set; }

    [DataMember]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [DataMember]
    [StringLength(11)]
    public string TaxPayerTaxCode { get; set; }

    [DataMember]
    public string TaxPayerName { get; set; }

    [DataMember]
    public string ExtraInfo { get; set; }

    public int? DocNum { get; set; }

    public int? ClientInternalID { get; set; }
}