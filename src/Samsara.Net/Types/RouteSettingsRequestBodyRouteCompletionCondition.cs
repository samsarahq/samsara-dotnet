using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RouteSettingsRequestBodyRouteCompletionCondition>))]
public enum RouteSettingsRequestBodyRouteCompletionCondition
{
    [EnumMember(Value = "arriveLastStop")]
    ArriveLastStop,

    [EnumMember(Value = "departLastStop")]
    DepartLastStop,
}
