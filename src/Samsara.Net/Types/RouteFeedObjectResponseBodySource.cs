using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RouteFeedObjectResponseBodySource>))]
public enum RouteFeedObjectResponseBodySource
{
    [EnumMember(Value = "automatic")]
    Automatic,

    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "admin")]
    Admin,
}
