using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SpeedingIntervalResponseBodySeverityLevel>))]
public enum SpeedingIntervalResponseBodySeverityLevel
{
    [EnumMember(Value = "light")]
    Light,

    [EnumMember(Value = "moderate")]
    Moderate,

    [EnumMember(Value = "heavy")]
    Heavy,

    [EnumMember(Value = "severe")]
    Severe,
}
