using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue>)
)]
public enum TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "closed")]
    Closed,
}
