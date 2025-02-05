using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TrailerStatReeferDoorStateZone1TypeResponseBodyValue>))]
public enum TrailerStatReeferDoorStateZone1TypeResponseBodyValue
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "closed")]
    Closed,
}
