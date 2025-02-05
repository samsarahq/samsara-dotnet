using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TrailerStatReeferDoorStateZone3TypeResponseBodyValue>))]
public enum TrailerStatReeferDoorStateZone3TypeResponseBodyValue
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "closed")]
    Closed,
}
