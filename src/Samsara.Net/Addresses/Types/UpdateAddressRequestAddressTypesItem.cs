using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Addresses;

[JsonConverter(typeof(EnumSerializer<UpdateAddressRequestAddressTypesItem>))]
public enum UpdateAddressRequestAddressTypesItem
{
    [EnumMember(Value = "yard")]
    Yard,

    [EnumMember(Value = "shortHaul")]
    ShortHaul,

    [EnumMember(Value = "workforceSite")]
    WorkforceSite,

    [EnumMember(Value = "riskZone")]
    RiskZone,

    [EnumMember(Value = "industrialSite")]
    IndustrialSite,

    [EnumMember(Value = "alertsOnly")]
    AlertsOnly,
}
