using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RouteFeedObjectResponseBodyOperation>))]
public enum RouteFeedObjectResponseBodyOperation
{
    [EnumMember(Value = "stop scheduled")]
    StopScheduled,

    [EnumMember(Value = "stop en route")]
    StopEnRoute,

    [EnumMember(Value = "stop skipped")]
    StopSkipped,

    [EnumMember(Value = "stop arrived")]
    StopArrived,

    [EnumMember(Value = "stop departed")]
    StopDeparted,

    [EnumMember(Value = "stop ETA updated")]
    StopEtaUpdated,

    [EnumMember(Value = "stop arrival time updated")]
    StopArrivalTimeUpdated,

    [EnumMember(Value = "stop completion time updated")]
    StopCompletionTimeUpdated,

    [EnumMember(Value = "stop order changed")]
    StopOrderChanged,

    [EnumMember(Value = "stop arrival prevented")]
    StopArrivalPrevented,
}
