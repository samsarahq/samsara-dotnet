using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RouteStopDetailsObjectResponseBodyOperation>))]
public enum RouteStopDetailsObjectResponseBodyOperation
{
    [EnumMember(Value = "stop arrived")]
    StopArrived,

    [EnumMember(Value = "stop departed")]
    StopDeparted,
}
