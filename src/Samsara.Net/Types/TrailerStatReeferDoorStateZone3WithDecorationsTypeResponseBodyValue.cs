using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue>)
)]
public enum TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "closed")]
    Closed,
}
