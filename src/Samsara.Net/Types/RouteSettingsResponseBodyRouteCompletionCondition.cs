using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RouteSettingsResponseBodyRouteCompletionCondition>))]
public enum RouteSettingsResponseBodyRouteCompletionCondition
{
    [EnumMember(Value = "arriveLastStop")]
    ArriveLastStop,

    [EnumMember(Value = "departLastStop")]
    DepartLastStop,
}
