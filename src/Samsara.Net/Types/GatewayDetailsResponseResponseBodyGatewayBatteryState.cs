using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<GatewayDetailsResponseResponseBodyGatewayBatteryState>))]
public enum GatewayDetailsResponseResponseBodyGatewayBatteryState
{
    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "ok")]
    Ok,

    [EnumMember(Value = "unknown")]
    Unknown,
}
