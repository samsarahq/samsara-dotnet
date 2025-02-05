using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetShift>))]
public enum DriverEldRulesetShift
{
    [EnumMember(Value = "US Interstate Property")]
    UsInterstateProperty,

    [EnumMember(Value = "US Interstate Passenger")]
    UsInterstatePassenger,

    [EnumMember(Value = "Texas Intrastate")]
    TexasIntrastate,
}
