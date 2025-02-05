using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<MinimalRouteStopResponseBodyState>))]
public enum MinimalRouteStopResponseBodyState
{
    [EnumMember(Value = "unassigned")]
    Unassigned,

    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "en route")]
    EnRoute,

    [EnumMember(Value = "skipped")]
    Skipped,

    [EnumMember(Value = "arrived")]
    Arrived,

    [EnumMember(Value = "departed")]
    Departed,
}
