using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BisSandboxApi.Web.Models;

public class TransferBatchVal
{
    [DataMember]
    [Required]
    public string SenderAcc { get; set; }

    [DataMember]
    [Required]
    [StringLength(3)]
    public string Ccy { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAcc { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAccName { get; set; }

    [DataMember]
    [Required]
    public string ReceiverAddress { get; set; }

    [DataMember]
    [Required]
    public string ReceiverBankCode { get; set; }

    [DataMember]
    [Required]
    public string ReceiverBankName { get; set; }

    [DataMember]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Amount { get; set; }

    [DataMember]
    public string Descrip { get; set; }

    [DataMember]
    public string ExtraInfo { get; set; }

    public string IntermediateBankCode { get; set; }

    public string IntermediateBankName { get; set; }

    public string DetailOfCharg { get; set; }

    public int? DocNum { get; set; }

    public int? ClientInternalID { get; set; }
}