using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetUsShortHaulType>))]
public enum DriverEldRulesetUsShortHaulType
{
    [EnumMember(Value = "100 Air-Mile (Passenger)")]
    OneHundredAirMilePassenger,

    [EnumMember(Value = "100 Air-Mile (Property)")]
    OneHundredAirMileProperty,

    [EnumMember(Value = "150 Air-Mile (Non-CDL)")]
    OneHundredFiftyAirMileNonCdl,
}
