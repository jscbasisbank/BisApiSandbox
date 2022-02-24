using System;
namespace BisSandboxApi.Web.Constants;

public static class BankCodes
{
    public static readonly Dictionary<string, Bank> Banks = new()
    {
        {
            "BS",
            new Bank
            {
                RtgsCode = "CBASGE22",
                Name = "სს \"ბაზისბანკი\""
            }
        },

        {
            "NB",
            new Bank
            {
                RtgsCode = "BNLNGE22",
                Name = "საქართველოს ეროვნული ბანკი"
            }
        },

        {
            "TR",
            new Bank
            {
                RtgsCode = "TRESGE22",
                Name = "საქართველოს ფინანსთა სამინისტროს სახაზინო სამსახური"
            }
        },

        {
            "BG",
            new Bank
            {
                RtgsCode = "BAGAGE22",
                Name = "სს \"საქართველოს ბანკი\""
            }
        },

        {
            "BT",
            new Bank
            {
                RtgsCode = "DISNGE22",
                Name = "სს \"სილქ როუდ ბანკი\""
            }
        },

        {
            "CR",
            new Bank
            {
                RtgsCode = "CRTUGE22",
                Name = "სს \"ბანკი ქართუ\""
            }
        },

        {
            "HB",
            new Bank
            {
                RtgsCode = "HABGGE22",
                Name = "სს \"ხალიკ ბანკი საქართველო\""
            }
        },

        {
            "KS",
            new Bank
            {
                RtgsCode = "TEBAGE22",
                Name = "სს \"ტერაბანკი\""
            }
        },

        {
            "LB",
            new Bank
            {
                RtgsCode = "LBRTGE22",
                Name = "სს \"ლიბერთი ბანკი\""
            }
        },

        {
            "PC",
            new Bank
            {
                RtgsCode = "MIBGGE22",
                Name = "სს \"პროკრედიტ ბანკი, საქართველო\""
            }
        },

        {
            "TB",
            new Bank
            {
                RtgsCode = "TBCBGE22",
                Name = "სს \"თიბისი ბანკი\""
            }
        },

        {
            "VT",
            new Bank
            {
                RtgsCode = "UGEBGE22",
                Name = "სს \"ვითიბი ბანკი ჯორჯია\""
            }
        },

        {
            "ZB",
            new Bank
            {
                RtgsCode = "TCZBGE22",
                Name = "სს \"ზირაათ ბანკი საქართველო\""
            }
        },

        {
            "PB",
            new Bank
            {
                RtgsCode = "PAHAGE22",
                Name = "სს \"პაშა ბანკი საქართველო\""
            }
        },

        {
            "IS",
            new Bank
            {
                RtgsCode = "ISBKGE22",
                Name = "სს \"იშბანკი საქართველო\""
            }
        },

        {
            "FG",
            new Bank
            {
                RtgsCode = "FGEOGE22",
                Name = "სს კრედო ბანკის დროებითი კოდი"
            }
        },

        {
            "CD",
            new Bank
            {
                RtgsCode = "JSCRGE22",
                Name = "სს \"კრედო ბანკი\""
            }
        }
    };
}

public class Bank
{
    public string Name { get; set; }
    public string RtgsCode { get; set; }
}
