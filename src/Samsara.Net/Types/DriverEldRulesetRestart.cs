using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetRestart>))]
public enum DriverEldRulesetRestart
{
    [EnumMember(Value = "None")]
    None,

    [EnumMember(Value = "34-hour Restart")]
    ThirtyFourHourRestart,

    [EnumMember(Value = "24-hour Restart")]
    TwentyFourHourRestart,

    [EnumMember(Value = "36-hour Restart")]
    ThirtySixHourRestart,

    [EnumMember(Value = "72-hour Restart")]
    SeventyTwoHourRestart,
}
