using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AmbientTemperatureDetailsObjectRequestBodyOperation>))]
public enum AmbientTemperatureDetailsObjectRequestBodyOperation
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
