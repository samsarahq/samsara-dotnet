using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverRulesetObjectResponseBodyShift>))]
public enum DriverRulesetObjectResponseBodyShift
{
    [EnumMember(Value = "US Interstate Property")]
    UsInterstateProperty,

    [EnumMember(Value = "US Interstate Passenger")]
    UsInterstatePassenger,
}
