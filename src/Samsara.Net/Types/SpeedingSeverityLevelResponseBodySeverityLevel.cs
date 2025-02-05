using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SpeedingSeverityLevelResponseBodySeverityLevel>))]
public enum SpeedingSeverityLevelResponseBodySeverityLevel
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
