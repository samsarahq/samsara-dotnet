using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue>)
)]
public enum TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "closed")]
    Closed,
}
