using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<IdlingEventObjectResponseBodyAddressType>))]
public enum IdlingEventObjectResponseBodyAddressType
{
    [EnumMember(Value = "agricultureSource")]
    AgricultureSource,

    [EnumMember(Value = "alertsOnly")]
    AlertsOnly,

    [EnumMember(Value = "industrialSite")]
    IndustrialSite,

    [EnumMember(Value = "riskZone")]
    RiskZone,

    [EnumMember(Value = "shortHaul")]
    ShortHaul,

    [EnumMember(Value = "undefined")]
    Undefined,

    [EnumMember(Value = "workforceSite")]
    WorkforceSite,

    [EnumMember(Value = "yard")]
    Yard,
}
