using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<MediaObjectResponseBodyInput>))]
public enum MediaObjectResponseBodyInput
{
    [EnumMember(Value = "dashcamDriverFacing")]
    DashcamDriverFacing,

    [EnumMember(Value = "dashcamRoadFacing")]
    DashcamRoadFacing,
}
