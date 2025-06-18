using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FuelCostObjectResponseBodyCurrency>))]
public enum FuelCostObjectResponseBodyCurrency
{
    [EnumMember(Value = "usd")]
    Usd,

    [EnumMember(Value = "gbp")]
    Gbp,

    [EnumMember(Value = "cad")]
    Cad,

    [EnumMember(Value = "eur")]
    Eur,

    [EnumMember(Value = "chf")]
    Chf,

    [EnumMember(Value = "mxn")]
    Mxn,
}
