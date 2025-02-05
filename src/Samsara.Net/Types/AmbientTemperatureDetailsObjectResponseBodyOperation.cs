using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AmbientTemperatureDetailsObjectResponseBodyOperation>))]
public enum AmbientTemperatureDetailsObjectResponseBodyOperation
{
    [EnumMember(Value = "GREATER")]
    Greater,

    [EnumMember(Value = "INSIDE_RANGE")]
    InsideRange,

    [EnumMember(Value = "LESS")]
    Less,

    [EnumMember(Value = "OUTSIDE_RANGE")]
    OutsideRange,
}
